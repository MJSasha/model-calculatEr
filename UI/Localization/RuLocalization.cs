﻿using ModelCalculater.DEfinitions;

namespace UI.Localization
{
	public class RuLocalization : ILocalization
	{
		#region Common

		public string Common_Ok => "Ok";
		public string Common_Cancel => "Отменить";

		#endregion

		#region Info dialog

		public string InfoDialog_Title => "Справка";
		public string InfoDialog_DescriptionText => "Эта программа представляет собой решение для определения статуса задачи";
		public string InfoDialog_DesignationsLabel => "Обозначения:";
		public string InfoDialog_FrameColorDescription_Blue => "Колонка, название которой выделено таким цветом - считается колонкой переменных";
		public string InfoDialog_FrameColorDescription_Red => "Колонка, название которой выделено таким цветом - считается колонкой данных значений";
		public string InfoDialog_FrameColorDescription_Green => "Колонка, название которой выделено таким цветом - считается колонкой искомых значений";

		#endregion

		#region Settings dialog

		public string SettingsDialog_Title => "Настройки";
		public string SettingsDialog_SaveButton => "Сохранить";
		public string SettingsDialog_PlayResultCheckbox => "Воспроизводить результат";

		#endregion

		#region Matrix page

		public string MatrixPage_EnterColumnName_ModalTitle => "Введите название колонки";
		public string MatrixPage_IncorrectColumnName_ModalTitle => "Некорректное название колонки";
		public string MatrixPage_IncorrectColumnName_ModalText => "Некорректное название колонки. Возможно колонка с таким названием уже существует";
		public string MatrixPage_Error_ModalTitle => "Ошибка";
		public string MatrixPage_Error_ModalText => "Вы должны указать матрицу";
		public string MatrixPage_Result_ModalTitle => "Результат";

		#endregion

		#region Nav menu

		public string NavMenu_Title => "Matrix calculater";
		public string NavMenu_Calculate => "Посчитать";
		public string NavMenu_Redact => "Редактировать";
		public string NavMenu_Clear => "Очистить";
		public string NavMenu_About => "Справка";
		public string NavMenu_Settings => "Настройки";

		#endregion

		#region Extensions

		public string GetName(TaskType taskType)
		{
			return taskType switch
			{
				TaskType.NoSolution => "Задача не имеет решений",
				TaskType.Estimated => "Задача вычисляемая",
				TaskType.Optimization => "Задача оптимизационная",
				_ => throw new NotImplementedException(),
			};
		}

		#endregion
	}
}