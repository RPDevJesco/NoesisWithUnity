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

public class CanExecuteRoutedEventArgs : RoutedEventArgs {
  private HandleRef swigCPtr;

  internal CanExecuteRoutedEventArgs(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CanExecuteRoutedEventArgs obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CanExecuteRoutedEventArgs() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_CanExecuteRoutedEventArgs(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public bool canExecute {
    set {
      NoesisGUI_PINVOKE.CanExecuteRoutedEventArgs_canExecute_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.CanExecuteRoutedEventArgs_canExecute_get(swigCPtr);
      return ret;
    } 
  }

  public bool continueRouting {
    set {
      NoesisGUI_PINVOKE.CanExecuteRoutedEventArgs_continueRouting_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.CanExecuteRoutedEventArgs_continueRouting_get(swigCPtr);
      return ret;
    } 
  }

}

}

