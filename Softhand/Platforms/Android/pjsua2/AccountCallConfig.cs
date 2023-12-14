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

public class AccountCallConfig : PersistentObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal AccountCallConfig(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.AccountCallConfig_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AccountCallConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_AccountCallConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public pjsua_call_hold_type holdType {
    set {
      pjsua2PINVOKE.AccountCallConfig_holdType_set(swigCPtr, (int)value);
    } 
    get {
      pjsua_call_hold_type ret = (pjsua_call_hold_type)pjsua2PINVOKE.AccountCallConfig_holdType_get(swigCPtr);
      return ret;
    } 
  }

  public pjsua_100rel_use prackUse {
    set {
      pjsua2PINVOKE.AccountCallConfig_prackUse_set(swigCPtr, (int)value);
    } 
    get {
      pjsua_100rel_use ret = (pjsua_100rel_use)pjsua2PINVOKE.AccountCallConfig_prackUse_get(swigCPtr);
      return ret;
    } 
  }

  public pjsua_sip_timer_use timerUse {
    set {
      pjsua2PINVOKE.AccountCallConfig_timerUse_set(swigCPtr, (int)value);
    } 
    get {
      pjsua_sip_timer_use ret = (pjsua_sip_timer_use)pjsua2PINVOKE.AccountCallConfig_timerUse_get(swigCPtr);
      return ret;
    } 
  }

  public uint timerMinSESec {
    set {
      pjsua2PINVOKE.AccountCallConfig_timerMinSESec_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.AccountCallConfig_timerMinSESec_get(swigCPtr);
      return ret;
    } 
  }

  public uint timerSessExpiresSec {
    set {
      pjsua2PINVOKE.AccountCallConfig_timerSessExpiresSec_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.AccountCallConfig_timerSessExpiresSec_get(swigCPtr);
      return ret;
    } 
  }

  public AccountCallConfig() : this(pjsua2PINVOKE.new_AccountCallConfig(), true) {
  }

  public override void readObject(ContainerNode node) {
    pjsua2PINVOKE.AccountCallConfig_readObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public override void writeObject(ContainerNode node) {
    pjsua2PINVOKE.AccountCallConfig_writeObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

}

}
