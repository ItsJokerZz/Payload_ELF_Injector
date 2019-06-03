using librpc;

namespace Payload_ELF_Injector
{
	class Calling
	{
		public static int version = 505;

		public static PS4RPC ps4 = Tool.ps4;

		public static ulong notifyStub = 0;
		public static int notifyPid = -1;
		public static MemoryEntry libSceLibcInternal = null;

		/// <summary>
		/// Allocate memory for function calls.
		/// </summary>
		/// <param name="size">Size of memory range to allocate</param>
		public static ulong malloc(int pid, ulong stub, int size)
		{
			ProcessInfo pi = ps4.GetProcessInfo(pid);
			MemoryEntry libSceLibcInternal = pi.FindEntry("libSceLibcInternal.sprx");

			if (version == 405)
				return ps4.Call(pid, stub, libSceLibcInternal.start + 0x382F0, size);
			else if (version == 455)
				return ps4.Call(pid, stub, libSceLibcInternal.start + 0x2C2A0, size);
			else if (version == 505)
				return ps4.Call(pid, stub, libSceLibcInternal.start + 0x23D90, size);
			else
				return ps4.Call(pid, stub, libSceLibcInternal.start + 0x23D90, size);
		}

		/// <summary>
		/// Free before allocated memory.
		/// </summary>
		/// <param name="address">Address to free</param>
		public static void free(ulong address)
		{
			if (version == 405)
				ps4.Call(notifyPid, notifyStub, libSceLibcInternal.start + 0x38380, address);
			else if (version == 455)
				ps4.Call(notifyPid, notifyStub, libSceLibcInternal.start + 0x2C330, address);
			else if (version == 505)
				ps4.Call(notifyPid, notifyStub, libSceLibcInternal.start + 0x23E20, address);
			else
				ps4.Call(notifyPid, notifyStub, libSceLibcInternal.start + 0x23E20, address);
		}

		/// <summary>
		/// Send a notify to the console.
		/// </summary>
		/// <param name="text">Notification string</param>
		/// <param name="type">Display style type</param>
		public static void Notify(string text, int type = 222)
		{
			ulong diff;

			if (version == 405)
				diff = 0x300;
			else if (version == 455)
				diff = 0x350;
			else if (version == 505)
				diff = 0x330;
			else
				diff = 0x330;

			ps4.Connect();

			if (notifyPid == -1)
			{
				ProcessList pl = ps4.GetProcessList();

				foreach (Process p in pl.processes)
				{
					if (p.name == "SceSysCore.elf")
					{
						notifyPid = p.pid;
					}
				}
			}

			ProcessInfo pi = ps4.GetProcessInfo(notifyPid);

			if (notifyStub == 0)
			{
				notifyStub = ps4.InstallRPC(notifyPid);
				libSceLibcInternal = pi.FindEntry("libSceLibcInternal.sprx");
			}

			ulong stringbuf = malloc(notifyPid, notifyStub, text.Length + 1);

			ps4.WriteString(notifyPid, stringbuf, text);

			MemoryEntry libSceSysUtil = pi.FindEntry("libSceSysUtil.sprx");

			ps4.Call(notifyPid, notifyStub, libSceSysUtil.start + diff, type, stringbuf);

			free(stringbuf);
		}
	}
}
