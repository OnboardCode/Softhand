//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pjsua2xamarin.pjsua2 {

public enum pjsip_transport_type_e {
  PJSIP_TRANSPORT_UNSPECIFIED,
  PJSIP_TRANSPORT_UDP,
  PJSIP_TRANSPORT_TCP,
  PJSIP_TRANSPORT_TLS,
  PJSIP_TRANSPORT_DTLS,
  PJSIP_TRANSPORT_SCTP,
  PJSIP_TRANSPORT_LOOP,
  PJSIP_TRANSPORT_LOOP_DGRAM,
  PJSIP_TRANSPORT_START_OTHER,
  PJSIP_TRANSPORT_IPV6 = 128,
  PJSIP_TRANSPORT_UDP6 = PJSIP_TRANSPORT_UDP+PJSIP_TRANSPORT_IPV6,
  PJSIP_TRANSPORT_TCP6 = PJSIP_TRANSPORT_TCP+PJSIP_TRANSPORT_IPV6,
  PJSIP_TRANSPORT_TLS6 = PJSIP_TRANSPORT_TLS+PJSIP_TRANSPORT_IPV6,
  PJSIP_TRANSPORT_DTLS6 = PJSIP_TRANSPORT_DTLS+PJSIP_TRANSPORT_IPV6
}

}
