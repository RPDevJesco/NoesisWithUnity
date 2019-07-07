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

public class VisualTransition : DependencyObject {
  internal new static VisualTransition CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new VisualTransition(cPtr, cMemoryOwn);
  }

  internal VisualTransition(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(VisualTransition obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public VisualTransition() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_VisualTransition();
  }

  public string From {
    set {
      NoesisGUI_PINVOKE.VisualTransition_From_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.VisualTransition_From_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public string To {
    set {
      NoesisGUI_PINVOKE.VisualTransition_To_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.VisualTransition_To_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public Duration GeneratedDuration {
    set {
      NoesisGUI_PINVOKE.VisualTransition_GeneratedDuration_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.VisualTransition_GeneratedDuration_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Duration>(ret);
      }
      else {
        return new Duration();
      }
    }

  }

  public EasingFunctionBase GeneratedEasingFunction {
    set {
      NoesisGUI_PINVOKE.VisualTransition_GeneratedEasingFunction_set(swigCPtr, EasingFunctionBase.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VisualTransition_GeneratedEasingFunction_get(swigCPtr);
      return (EasingFunctionBase)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Storyboard Storyboard {
    set {
      NoesisGUI_PINVOKE.VisualTransition_Storyboard_set(swigCPtr, Storyboard.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.VisualTransition_Storyboard_get(swigCPtr);
      return (Storyboard)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.VisualTransition_GetStaticType();
    return ret;
  }

}

}

