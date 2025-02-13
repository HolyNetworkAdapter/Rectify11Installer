﻿using Rectify11Installer.Pages;
using System.Collections.Generic;

namespace Rectify11Installer.Core
{
	public class RectifyPages
	{
		public static WelcomePage WelcomePage = new WelcomePage();
		public static EulaPage EulaPage = new EulaPage();
		public static InstallOptnsPage InstallOptnsPage;
		public static ThemeChoicePage ThemeChoicePage = new ThemeChoicePage();
		public static EPPage EPPage = new EPPage();
		public static InstallConfirmation InstallConfirmation = new InstallConfirmation();
		public static ProgressPage ProgressPage;
		public static Experimental ExperimentalPage = new Experimental();
	}
	public class InstallOptions
	{
		public static bool InstallEP;
		public static bool InstallASDF;
		public static bool InstallWallpaper;
		public static bool InstallWinver;
		public static bool InstallThemes;
		public static bool ThemeDark;
		public static bool ThemeBlack;
		public static bool ThemeLight;
		public static bool InstallShell;
		public static bool InstallIcons;
		public static List<string> iconsList = new List<string>();
		public static bool InstallExtras()
		{
			if (InstallEP
				|| InstallASDF
				|| InstallWallpaper
				|| InstallWinver
				|| InstallShell)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
