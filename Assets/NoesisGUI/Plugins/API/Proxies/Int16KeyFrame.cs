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

public class Int16KeyFrame : Freezable {
  internal new static Int16KeyFrame CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Int16KeyFrame(cPtr, cMemoryOwn);
  }

  internal Int16KeyFrame(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Int16KeyFrame obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected Int16KeyFrame() {
  }

  public static DependencyProperty KeyTimeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Int16KeyFrame_KeyTimeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ValueProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.Int16KeyFrame_ValueProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public KeyTime KeyTime {
    set {
      NoesisGUI_PINVOKE.Int16KeyFrame_KeyTime_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.Int16KeyFrame_KeyTime_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<KeyTime>(ret);
      }
      else {
        return new KeyTime();
      }
    }

  }

  public short Value {
    set {
      NoesisGUI_PINVOKE.Int16KeyFrame_Value_set(swigCPtr, value);
    } 
    get {
      short ret = NoesisGUI_PINVOKE.Int16KeyFrame_Value_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.Int16KeyFrame_GetStaticType();
    return ret;
  }

}

}

