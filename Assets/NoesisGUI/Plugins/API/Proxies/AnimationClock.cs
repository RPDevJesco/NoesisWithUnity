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

public class AnimationClock : Clock {
  internal new static AnimationClock CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new AnimationClock(cPtr, cMemoryOwn);
  }

  internal AnimationClock(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(AnimationClock obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected AnimationClock() {
  }

  public AnimationClock(AnimationTimeline animation, bool controllable) : this(NoesisGUI_PINVOKE.new_AnimationClock(AnimationTimeline.getCPtr(animation), controllable), true) {
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.AnimationClock_GetStaticType();
    return ret;
  }

}

}
