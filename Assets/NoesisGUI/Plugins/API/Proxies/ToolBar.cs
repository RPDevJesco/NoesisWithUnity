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

public class ToolBar : HeaderedItemsControl {
  internal new static ToolBar CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new ToolBar(cPtr, cMemoryOwn);
  }

  internal ToolBar(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(ToolBar obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public ToolBar() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(ToolBar)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_ToolBar();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static OverflowMode GetOverflowMode(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      OverflowMode ret = (OverflowMode)NoesisGUI_PINVOKE.ToolBar_GetOverflowMode(DependencyObject.getCPtr(element));
      return ret;
    }
  }

  public static void SetOverflowMode(DependencyObject element, OverflowMode mode) {
    if (element == null) throw new ArgumentNullException("element");
    {
      NoesisGUI_PINVOKE.ToolBar_SetOverflowMode(DependencyObject.getCPtr(element), (int)mode);
    }
  }

  public static bool GetIsOverflowItem(DependencyObject element) {
    if (element == null) throw new ArgumentNullException("element");
    {
      bool ret = NoesisGUI_PINVOKE.ToolBar_GetIsOverflowItem(DependencyObject.getCPtr(element));
      return ret;
    }
  }

  public static DependencyProperty BandIndexProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_BandIndexProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty BandProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_BandProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty HasOverflowItemsProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_HasOverflowItemsProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsOverflowItemProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_IsOverflowItemProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsOverflowOpenProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_IsOverflowOpenProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty OrientationProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_OrientationProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty OverflowModeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_OverflowModeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ButtonStyleKey {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_ButtonStyleKey_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ToggleButtonStyleKey {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_ToggleButtonStyleKey_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CheckBoxStyleKey {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_CheckBoxStyleKey_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty RadioButtonStyleKey {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_RadioButtonStyleKey_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TextBoxStyleKey {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_TextBoxStyleKey_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ComboBoxStyleKey {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_ComboBoxStyleKey_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty SeparatorStyleKey {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_SeparatorStyleKey_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty MenuStyleKey {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.ToolBar_MenuStyleKey_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public int Band {
    set {
      NoesisGUI_PINVOKE.ToolBar_Band_set(swigCPtr, value);
    } 
    get {
      int ret = NoesisGUI_PINVOKE.ToolBar_Band_get(swigCPtr);
      return ret;
    } 
  }

  public int BandIndex {
    set {
      NoesisGUI_PINVOKE.ToolBar_BandIndex_set(swigCPtr, value);
    } 
    get {
      int ret = NoesisGUI_PINVOKE.ToolBar_BandIndex_get(swigCPtr);
      return ret;
    } 
  }

  public bool HasOverflowItems {
    get {
      bool ret = NoesisGUI_PINVOKE.ToolBar_HasOverflowItems_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsOverflowOpen {
    set {
      NoesisGUI_PINVOKE.ToolBar_IsOverflowOpen_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.ToolBar_IsOverflowOpen_get(swigCPtr);
      return ret;
    } 
  }

  public Orientation Orientation {
    get {
      Orientation ret = (Orientation)NoesisGUI_PINVOKE.ToolBar_Orientation_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.ToolBar_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_ToolBar(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}
