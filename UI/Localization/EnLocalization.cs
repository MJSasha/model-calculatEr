﻿using ModelCalculater.DEfinitions;

namespace UI.Localization
{
	public class EnLocalization : ILocalization
	{
		#region Common

		public string Common_Ok => "Ok";
		public string Common_Cancel => "Cancel";

		#endregion

		#region Info dialog

		public string InfoDialog_Title => "About";
		public string InfoDialog_DescriptionText => "This program is a solution for determining the status of the task";
		public string InfoDialog_DesignationsLabel => "Designations:";
		public string InfoDialog_FrameColorDescription_Blue => "A column whose name is highlighted in this color is considered a column of variables";
		public string InfoDialog_FrameColorDescription_Red => "A column whose name is highlighted in this color is considered a column of the specified parameters";
		public string InfoDialog_FrameColorDescription_Green => "A column whose name is highlighted in this color is considered a column of the desired";

		#endregion

		#region Settings dialog

		public string SettingsDialog_Title => "Settings";
		public string SettingsDialog_SaveButton => "Save";
		public string SettingsDialog_PlayResultCheckbox => "Play the result";

		#endregion

		#region Matrix page

		public string MatrixPage_EnterColumnName_ModalTitle => "Enter column name";
		public string MatrixPage_IncorrectColumnName_ModalTitle => "Incorrect column name";
		public string MatrixPage_IncorrectColumnName_ModalText => "Incorrect column name. Perhaps a column with this name already exists";
		public string MatrixPage_Error_ModalTitle => "Error";
		public string MatrixPage_Error_ModalText => "You have to specify the matrix";
		public string MatrixPage_Result_ModalTitle => "Result";

		#endregion

		#region Nav menu

		public string NavMenu_Title => "Matrix calculater";
		public string NavMenu_Calculate => "Calculate";
		public string NavMenu_Redact => "Redact";
		public string NavMenu_Clear => "Clear";
		public string NavMenu_About => "About";
		public string NavMenu_Settings => "Settings";

		#endregion

		#region Extensions

		public string GetName(TaskType taskType)
		{
			return taskType switch
			{
				TaskType.NoSolution => "The task has no solutions",
				TaskType.Estimated => "The task is calculated",
				TaskType.Optimization => "Optimization task",
				_ => throw new NotImplementedException(),
			};
		}

		#endregion
	}
}
