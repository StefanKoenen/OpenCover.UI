﻿//
// This source code is released under the MIT License; Please read license.md file for more details.
//
using OpenCover.UI.Helpers;
using OpenCover.UI.Model;
using System;
using System.Windows.Data;

namespace OpenCover.UI.Converters
{
	/// <summary>
	/// Converts Test Execution Status to Icon
	/// </summary>
	public class TestExecutionResultStatusToIconConverter : IValueConverter
	{
		/// <summary>
		/// Converts a value.
		/// </summary>
		/// <param name="value">The value produced by the binding source.</param>
		/// <param name="targetType">The type of the binding target property.</param>
		/// <param name="parameter">The converter parameter to use.</param>
		/// <param name="culture">The culture to use in the converter.</param>
		/// <returns>
		/// A converted value. If the method returns null, the valid null value is used.
		/// </returns>
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return IDEHelper.GetImageURL(IDEHelper.GetIcon((TestExecutionStatus)value));
		}

		/// <summary>
		/// Converts a value.
		/// </summary>
		/// <param name="value">The value that is produced by the binding target.</param>
		/// <param name="targetType">The type to convert to.</param>
		/// <param name="parameter">The converter parameter to use.</param>
		/// <param name="culture">The culture to use in the converter.</param>
		/// <returns>
		/// A converted value. If the method returns null, the valid null value is used.
		/// </returns>
		/// <exception cref="System.NotImplementedException"></exception>
		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}