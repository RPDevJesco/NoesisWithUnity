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

public class BeginStoryboard : TriggerAction {
  internal new static BeginStoryboard CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new BeginStoryboard(cPtr, cMemoryOwn);
  }

  internal BeginStoryboard(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(BeginStoryboard obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public BeginStoryboard() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_BeginStoryboard();
  }

  public static DependencyProperty StoryboardProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.BeginStoryboard_StoryboardProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public HandoffBehavior HandoffBehavior {
    set {
      NoesisGUI_PINVOKE.BeginStoryboard_HandoffBehavior_set(swigCPtr, (int)value);
    } 
    get {
      HandoffBehavior ret = (HandoffBehavior)NoesisGUI_PINVOKE.BeginStoryboard_HandoffBehavior_get(swigCPtr);
      return ret;
    } 
  }

  public string Name {
    set {
      NoesisGUI_PINVOKE.BeginStoryboard_Name_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.BeginStoryboard_Name_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public Storyboard Storyboard {
    set {
      NoesisGUI_PINVOKE.BeginStoryboard_Storyboard_set(swigCPtr, Storyboard.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.BeginStoryboard_Storyboard_get(swigCPtr);
      return (Storyboard)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.BeginStoryboard_GetStaticType();
    return ret;
  }

}

}

