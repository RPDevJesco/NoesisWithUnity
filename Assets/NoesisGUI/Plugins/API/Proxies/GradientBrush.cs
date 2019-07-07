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

public class GradientBrush : Brush {
  internal new static GradientBrush CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new GradientBrush(cPtr, cMemoryOwn);
  }

  internal GradientBrush(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(GradientBrush obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected GradientBrush() {
  }

  public static DependencyProperty ColorInterpolationModeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GradientBrush_ColorInterpolationModeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty GradientStopsProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GradientBrush_GradientStopsProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty MappingModeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GradientBrush_MappingModeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty SpreadMethodProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GradientBrush_SpreadMethodProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public ColorInterpolationMode ColorInterpolationMode {
    set {
      NoesisGUI_PINVOKE.GradientBrush_ColorInterpolationMode_set(swigCPtr, (int)value);
    } 
    get {
      ColorInterpolationMode ret = (ColorInterpolationMode)NoesisGUI_PINVOKE.GradientBrush_ColorInterpolationMode_get(swigCPtr);
      return ret;
    } 
  }

  public GradientStopCollection GradientStops {
    set {
      NoesisGUI_PINVOKE.GradientBrush_GradientStops_set(swigCPtr, GradientStopCollection.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.GradientBrush_GradientStops_get(swigCPtr);
      return (GradientStopCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public BrushMappingMode MappingMode {
    set {
      NoesisGUI_PINVOKE.GradientBrush_MappingMode_set(swigCPtr, (int)value);
    } 
    get {
      BrushMappingMode ret = (BrushMappingMode)NoesisGUI_PINVOKE.GradientBrush_MappingMode_get(swigCPtr);
      return ret;
    } 
  }

  public GradientSpreadMethod SpreadMethod {
    set {
      NoesisGUI_PINVOKE.GradientBrush_SpreadMethod_set(swigCPtr, (int)value);
    } 
    get {
      GradientSpreadMethod ret = (GradientSpreadMethod)NoesisGUI_PINVOKE.GradientBrush_SpreadMethod_get(swigCPtr);
      return ret;
    } 
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.GradientBrush_GetStaticType();
    return ret;
  }

}

}

