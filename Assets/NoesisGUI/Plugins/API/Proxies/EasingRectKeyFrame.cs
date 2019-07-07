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

public class EasingRectKeyFrame : RectKeyFrame {
  internal new static EasingRectKeyFrame CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new EasingRectKeyFrame(cPtr, cMemoryOwn);
  }

  internal EasingRectKeyFrame(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(EasingRectKeyFrame obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public EasingRectKeyFrame() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_EasingRectKeyFrame();
  }

  public static DependencyProperty EasingFunctionProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.EasingRectKeyFrame_EasingFunctionProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public EasingFunctionBase EasingFunction {
    set {
      NoesisGUI_PINVOKE.EasingRectKeyFrame_EasingFunction_set(swigCPtr, EasingFunctionBase.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.EasingRectKeyFrame_EasingFunction_get(swigCPtr);
      return (EasingFunctionBase)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.EasingRectKeyFrame_GetStaticType();
    return ret;
  }

}

}
