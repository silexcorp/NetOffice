﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
    /// <summary>
    /// RoutingSlip
    /// </summary>
    [SyntaxBypass]
    public class RoutingSlip_ : COMObject, NetOffice.ExcelApi.RoutingSlip_
    {
        #region Ctor

        /// <summary>
        /// Stub Ctor, not indented to use
        /// </summary>
        public RoutingSlip_() : base()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <param name="index">optional object index</param>
        /// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff821813.aspx
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public object get_Recipients(object index)
        {
            return Factory.ExecuteVariantPropertyGet(this, "Recipients", index);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <param name="index">optional object index</param>
        /// <param name="value">optional object value</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void set_Recipients(object index, object value)
        {
            Factory.ExecutePropertySet(this, "Recipients", index, value);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Alias for get_Recipients
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821813.aspx </remarks>
        /// <param name="index">optional object index</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), Redirect("get_Recipients")]
        public object Recipients(object index)
        {
            return get_Recipients(index);
        }

        #endregion

        #region Methods

        #endregion
    }

    /// <summary>
    /// DispatchInterface RoutingSlip 
    /// SupportByVersion Excel, 9,10,11,12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff194090.aspx </remarks>
    [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class RoutingSlip : NetOffice.ExcelApi.Behind.RoutingSlip_, NetOffice.ExcelApi.RoutingSlip
    {
        #pragma warning disable

        #region Type Information

        /// <summary>
        /// Instance Type
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
                    _type = typeof(RoutingSlip);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Stub Ctor, not indented to use
        /// </summary>
        public RoutingSlip() : base()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193911.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.Application Application
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822853.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.Enums.XlCreator Creator
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff198207.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff198327.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.Enums.XlRoutingSlipDelivery Delivery
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlRoutingSlipDelivery>(this, "Delivery");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "Delivery", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197554.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object Message
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Message");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Message", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821813.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object Recipients
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Recipients");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Recipients", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff841216.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public bool ReturnWhenDone
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "ReturnWhenDone");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "ReturnWhenDone", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835866.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.Enums.XlRoutingSlipStatus Status
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlRoutingSlipStatus>(this, "Status");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822772.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object Subject
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Subject");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Subject", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197168.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public bool TrackStatus
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "TrackStatus");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "TrackStatus", value);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835881.aspx </remarks>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object Reset()
        {
            return Factory.ExecuteVariantMethodGet(this, "Reset");
        }

        #endregion

        #pragma warning restore
    }
}
