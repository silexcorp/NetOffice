﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.MSHTMLApi;

namespace NetOffice.MSHTMLApi.Behind
{
	/// <summary>
	/// Interface IElementBehaviorSite 
	/// SupportByVersion MSHTML, 4
	/// </summary>
	[SupportByVersion("MSHTML", 4)]
	[EntityType(EntityType.IsInterface)]
 	public class IElementBehaviorSite : COMObject, NetOffice.MSHTMLApi.IElementBehaviorSite
	{
		#pragma warning disable

		#region Type Information

        /// <summary>
        /// Contract Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type ContractType
        {
            get
            {
                if(null == _contractType)
                    _contractType = typeof(NetOffice.MSHTMLApi.IElementBehaviorSite);
                return _contractType;
            }
        }
        private static Type _contractType;


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
                    _type = typeof(IElementBehaviorSite);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IElementBehaviorSite() : base()
		{

		}

		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		[SupportByVersion("MSHTML", 4)]
		[BaseResult]
		public virtual NetOffice.MSHTMLApi.IHTMLElement GetElement()
		{
			return InvokerService.InvokeInternal.ExecuteBaseReferenceMethodGet<NetOffice.MSHTMLApi.IHTMLElement>(this, "GetElement");
		}

		/// <summary>
		/// SupportByVersion MSHTML 4
		/// </summary>
		/// <param name="lEvent">Int32 lEvent</param>
		[SupportByVersion("MSHTML", 4)]
		public virtual Int32 RegisterNotification(Int32 lEvent)
		{
			return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "RegisterNotification", lEvent);
		}

		#endregion

		#pragma warning restore
	}
}

