﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using NetOffice;
using NetOffice.Attributes;

namespace NetOffice.ExcelApi.EventContracts
{
    /// <summary>
    /// DocEvents
    /// </summary>
    [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
    [InternalEntity(InternalEntityKind.ComEventInterface)]
    [ComImport, Guid("00024411-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
    public interface DocEvents
    {
        /// <summary>
        /// SelectionChange
        /// </summary>
        /// <param name="target"></param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [SinkArgument("target", typeof(ExcelApi.Range))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1543)]
        void SelectionChange([In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// BeforeDoubleClick
        /// </summary>
        /// <param name="target"></param>
        /// <param name="cancel"></param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [SinkArgument("target", typeof(ExcelApi.Range))]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1537)]
        void BeforeDoubleClick([In, MarshalAs(UnmanagedType.IDispatch)] object target, [In] [Out] ref object cancel);

        /// <summary>
        /// BeforeRightClick
        /// </summary>
        /// <param name="target"></param>
        /// <param name="cancel"></param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [SinkArgument("target", typeof(ExcelApi.Range))]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1534)]
        void BeforeRightClick([In, MarshalAs(UnmanagedType.IDispatch)] object target, [In] [Out] ref object cancel);

        /// <summary>
        /// Activate
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(304)]
        void Activate();

        /// <summary>
        /// Deactivate
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1530)]
        void Deactivate();

        /// <summary>
        /// Calculate
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(279)]
        void Calculate();

        /// <summary>
        /// Change
        /// </summary>
        /// <param name="target"></param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [SinkArgument("target", typeof(ExcelApi.Range))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1545)]
        void Change([In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// FollowHyperlink
        /// </summary>
        /// <param name="target"></param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [SinkArgument("target", typeof(ExcelApi.Hyperlink))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(1470)]
        void FollowHyperlink([In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// PivotTableUpdate
        /// </summary>
        /// <param name="target"></param>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        [SinkArgument("target", typeof(ExcelApi.PivotTable))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2156)]
        void PivotTableUpdate([In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// PivotTableAfterValueChange
        /// </summary>
        /// <param name="targetPivotTable"></param>
        /// <param name="targetRange"></param>
        [SupportByVersion("Excel", 14, 15, 16)]
        [SinkArgument("targetPivotTable", typeof(ExcelApi.PivotTable))]
        [SinkArgument("targetRange", typeof(ExcelApi.Range))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2886)]
        void PivotTableAfterValueChange([In, MarshalAs(UnmanagedType.IDispatch)] object targetPivotTable, [In, MarshalAs(UnmanagedType.IDispatch)] object targetRange);

        /// <summary>
        /// PivotTableBeforeAllocateChanges
        /// </summary>
        /// <param name="targetPivotTable"></param>
        /// <param name="valueChangeStart"></param>
        /// <param name="valueChangeEnd"></param>
        /// <param name="cancel"></param>
        [SupportByVersion("Excel", 14, 15, 16)]
        [SinkArgument("targetPivotTable", typeof(ExcelApi.PivotTable))]
        [SinkArgument("valueChangeStart", SinkArgumentType.Int32)]
        [SinkArgument("valueChangeEnd", SinkArgumentType.Int32)]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2889)]
        void PivotTableBeforeAllocateChanges([In, MarshalAs(UnmanagedType.IDispatch)] object targetPivotTable, [In] object valueChangeStart, [In] object valueChangeEnd, [In] [Out] ref object cancel);

        /// <summary>
        /// PivotTableBeforeCommitChanges
        /// </summary>
        /// <param name="targetPivotTable"></param>
        /// <param name="valueChangeStart"></param>
        /// <param name="valueChangeEnd"></param>
        /// <param name="cancel"></param>
        [SupportByVersion("Excel", 14, 15, 16)]
        [SinkArgument("targetPivotTable", typeof(ExcelApi.PivotTable))]
        [SinkArgument("valueChangeStart", SinkArgumentType.Int32)]
        [SinkArgument("valueChangeEnd", SinkArgumentType.Int32)]
        [SinkArgument("cancel", SinkArgumentType.Bool)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2892)]
        void PivotTableBeforeCommitChanges([In, MarshalAs(UnmanagedType.IDispatch)] object targetPivotTable, [In] object valueChangeStart, [In] object valueChangeEnd, [In] [Out] ref object cancel);

        /// <summary>
        /// PivotTableBeforeDiscardChanges
        /// </summary>
        /// <param name="targetPivotTable"></param>
        /// <param name="valueChangeStart"></param>
        /// <param name="valueChangeEnd"></param>
        [SupportByVersion("Excel", 14, 15, 16)]
        [SinkArgument("targetPivotTable", typeof(ExcelApi.PivotTable))]
        [SinkArgument("valueChangeStart", SinkArgumentType.Int32)]
        [SinkArgument("valueChangeEnd", SinkArgumentType.Int32)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2893)]
        void PivotTableBeforeDiscardChanges([In, MarshalAs(UnmanagedType.IDispatch)] object targetPivotTable, [In] object valueChangeStart, [In] object valueChangeEnd);

        /// <summary>
        /// PivotTableChangeSync
        /// </summary>
        /// <param name="target"></param>
        [SupportByVersion("Excel", 14, 15, 16)]
        [SinkArgument("target", typeof(ExcelApi.PivotTable))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(2894)]
        void PivotTableChangeSync([In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// LensGalleryRenderComplete
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(3070)]
        void LensGalleryRenderComplete();

        /// <summary>
        /// TableUpdate
        /// </summary>
        /// <param name="target"></param>
        [SupportByVersion("Excel", 15, 16)]
        [SinkArgument("target", typeof(ExcelApi.TableObject))]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(3071)]
        void TableUpdate([In, MarshalAs(UnmanagedType.IDispatch)] object target);

        /// <summary>
        /// BeforeDelete
        /// </summary>
        [SupportByVersion("Excel", 15, 16)]
        [PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(3072)]
        void BeforeDelete();
    }
}
