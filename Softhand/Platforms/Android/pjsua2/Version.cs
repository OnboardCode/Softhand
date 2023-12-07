//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pjsua2xamarin.pjsua2 {

public class Version : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Version(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Version obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Version() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_Version(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int major {
    set {
      pjsua2PINVOKE.Version_major_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.Version_major_get(swigCPtr);
      return ret;
    } 
  }

  public int minor {
    set {
      pjsua2PINVOKE.Version_minor_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.Version_minor_get(swigCPtr);
      return ret;
    } 
  }

  public int rev {
    set {
      pjsua2PINVOKE.Version_rev_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.Version_rev_get(swigCPtr);
      return ret;
    } 
  }

  public string suffix {
    set {
      pjsua2PINVOKE.Version_suffix_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.Version_suffix_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string full {
    set {
      pjsua2PINVOKE.Version_full_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.Version_full_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint numeric {
    set {
      pjsua2PINVOKE.Version_numeric_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.Version_numeric_get(swigCPtr);
      return ret;
    } 
  }

  public Version() : this(pjsua2PINVOKE.new_Version(), true) {
  }

}

}
