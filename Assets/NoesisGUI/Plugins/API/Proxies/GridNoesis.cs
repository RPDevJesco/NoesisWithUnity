//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public class Grid : Panel {
  internal new static Grid CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Grid(cPtr, cMemoryOwn);
  }

  internal Grid(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Grid obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Grid() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(Grid)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_Grid();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static int GetColumn(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      int ret = NoesisGUI_PINVOKE.Grid_GetColumn(DependencyObject.getCPtr(element));
      return ret;
    }
  }

  public static void SetColumn(DependencyObject element, int column) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.Grid_SetColumn(DependencyObject.getCPtr(element), column);
    }
  }

  public static int GetColumnSpan(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      int ret = NoesisGUI_PINVOKE.Grid_GetColumnSpan(DependencyObject.getCPtr(element));
      return ret;
    }
  }

  public static void SetColumnSpan(DependencyObject element, int columnSpan) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.Grid_SetColumnSpan(DependencyObject.getCPtr(element), columnSpan);
    }
  }

  public static bool GetIsSharedSizeScope(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      bool ret = NoesisGUI_PINVOKE.Grid_GetIsSharedSizeScope(DependencyObject.getCPtr(element));
      return ret;
    }
  }

  public static void SetIsSharedSizeScope(DependencyObject element, bool value) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.Grid_SetIsSharedSizeScope(DependencyObject.getCPtr(element), value);
    }
  }

  public static int GetRow(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      int ret = NoesisGUI_PINVOKE.Grid_GetRow(DependencyObject.getCPtr(element));
      return ret;
    }
  }

  public static void SetRow(DependencyObject element, int row) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.Grid_SetRow(DependencyObject.getCPtr(element), row);
    }
  }

  public static int GetRowSpan(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      int ret = NoesisGUI_PINVOKE.Grid_GetRowSpan(DependencyObject.getCPtr(element));
      return ret;
    }
  }

  public static void SetRowSpan(DependencyObject element, int rowSpan) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.Grid_SetRowSpan(DependencyObject.getCPtr(element), rowSpan);
    }
  }

  public static DependencyProperty ColumnProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Grid_ColumnProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ColumnSpanProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Grid_ColumnSpanProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsSharedSizeScopeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Grid_IsSharedSizeScopeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty RowProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Grid_RowProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty RowSpanProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Grid_RowSpanProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public ColumnDefinitionCollection ColumnDefinitions {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Grid_ColumnDefinitions_get(swigCPtr);
      return (ColumnDefinitionCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public RowDefinitionCollection RowDefinitions {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Grid_RowDefinitions_get(swigCPtr);
      return (RowDefinitionCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.Grid_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_Grid(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

