﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// Interface ISlicerCache 
	/// SupportByVersion Excel, 14,15,16
	/// </summary>
	[SupportByVersion("Excel", 14,15,16)]
	[EntityType(EntityType.IsInterface)]
 	public class ISlicerCache : COMObject, NetOffice.ExcelApi.ISlicerCache
	{
		#pragma warning disable

		#region Type Information

        /// <summary>        /// Instance Type
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ISlicerCache);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public ISlicerCache() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Excel", 14,15,16), ProxyResult]
		public object Parent
		{
			get
			{
				return Factory.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public Int32 Index
		{
			get
			{
				return Factory.ExecuteInt32PropertyGet(this, "Index");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public bool OLAP
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "OLAP");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.Enums.XlPivotTableSourceType SourceType
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlPivotTableSourceType>(this, "SourceType");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.WorkbookConnection WorkbookConnection
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.WorkbookConnection>(this, "WorkbookConnection", typeof(NetOffice.ExcelApi.WorkbookConnection));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.Slicers Slicers
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Slicers>(this, "Slicers", typeof(NetOffice.ExcelApi.Slicers));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.SlicerPivotTables PivotTables
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.SlicerPivotTables>(this, "PivotTables", typeof(NetOffice.ExcelApi.SlicerPivotTables));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.SlicerCacheLevels SlicerCacheLevels
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.SlicerCacheLevels>(this, "SlicerCacheLevels", typeof(NetOffice.ExcelApi.SlicerCacheLevels));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public string Name
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "Name");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "Name", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.SlicerItems VisibleSlicerItems
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.SlicerItems>(this, "VisibleSlicerItems", typeof(NetOffice.ExcelApi.SlicerItems));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public object VisibleSlicerItemsList
		{
			get
			{
				return Factory.ExecuteVariantPropertyGet(this, "VisibleSlicerItemsList");
			}
			set
			{
				Factory.ExecuteVariantPropertySet(this, "VisibleSlicerItemsList", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.SlicerItems SlicerItems
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.SlicerItems>(this, "SlicerItems", typeof(NetOffice.ExcelApi.SlicerItems));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.Enums.XlSlicerCrossFilterType CrossFilterType
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlSlicerCrossFilterType>(this, "CrossFilterType");
			}
			set
			{
				Factory.ExecuteEnumPropertySet(this, "CrossFilterType", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public NetOffice.ExcelApi.Enums.XlSlicerSort SortItems
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlSlicerSort>(this, "SortItems");
			}
			set
			{
				Factory.ExecuteEnumPropertySet(this, "SortItems", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public string SourceName
		{
			get
			{
				return Factory.ExecuteStringPropertyGet(this, "SourceName");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public bool SortUsingCustomLists
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "SortUsingCustomLists");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "SortUsingCustomLists", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public bool ShowAllItems
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "ShowAllItems");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "ShowAllItems", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public NetOffice.ExcelApi.TimelineState TimelineState
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.TimelineState>(this, "TimelineState", typeof(NetOffice.ExcelApi.TimelineState));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public NetOffice.ExcelApi.Enums.XlSlicerCacheType SlicerCacheType
		{
			get
			{
				return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlSlicerCacheType>(this, "SlicerCacheType");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public bool FilterCleared
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "FilterCleared");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public bool List
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "List");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public bool RequireManualUpdate
		{
			get
			{
				return Factory.ExecuteBoolPropertyGet(this, "RequireManualUpdate");
			}
			set
			{
				Factory.ExecuteValuePropertySet(this, "RequireManualUpdate", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public NetOffice.ExcelApi.ListObject ListObject
		{
			get
			{
				return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ListObject>(this, "ListObject", typeof(NetOffice.ExcelApi.ListObject));
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public Int32 ClearManualFilter()
		{
			return Factory.ExecuteInt32MethodGet(this, "ClearManualFilter");
		}

		/// <summary>
		/// SupportByVersion Excel 14, 15, 16
		/// </summary>
		[SupportByVersion("Excel", 14,15,16)]
		public Int32 Delete()
		{
			return Factory.ExecuteInt32MethodGet(this, "Delete");
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public Int32 ClearAllFilters()
		{
			return Factory.ExecuteInt32MethodGet(this, "ClearAllFilters");
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public Int32 ClearDateFilter()
		{
			return Factory.ExecuteInt32MethodGet(this, "ClearDateFilter");
		}

		#endregion

		#pragma warning restore
	}
}

