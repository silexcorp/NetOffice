﻿using System.Collections;
using System.Collections.Generic;
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.CollectionsGeneric;

namespace NetOffice.ExcelApi
{
	/// <summary>
	/// DispatchInterface ModelTableNameChanges 
	/// SupportByVersion Excel, 15, 16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj230224.aspx </remarks>
	[SupportByVersion("Excel", 15, 16)]
	[EntityType(EntityType.IsDispatchInterface), Enumerator(Enumerator.Reference, EnumeratorInvoke.Property, "Excel", 15, 16), HasIndexProperty(IndexInvoke.Property, "_Default")]
	[TypeId("000244E3-0000-0000-C000-000000000046")]
	public interface ModelTableNameChanges : ICOMObject, IEnumerableProvider<NetOffice.ExcelApi.ModelTableNameChange>
	{
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231472.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		NetOffice.ExcelApi.Application Application { get; }

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj228830.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		NetOffice.ExcelApi.Enums.XlCreator Creator { get; }

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj232203.aspx </remarks>
		[SupportByVersion("Excel", 15, 16), ProxyResult]
		object Parent { get; }

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/jj231457.aspx </remarks>
		[SupportByVersion("Excel", 15, 16)]
		Int32 Count { get; }

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByVersion("Excel", 15, 16)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item"), IndexProperty]
		NetOffice.ExcelApi.ModelTableNameChange this[object index] { get; }

        #endregion

        #region IEnumerable<NetOffice.ExcelApi.ModelTableNameChange>

        /// <summary>
        /// SupportByVersion Excel, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        new IEnumerator<NetOffice.ExcelApi.ModelTableNameChange> GetEnumerator();

        #endregion
    }
}
