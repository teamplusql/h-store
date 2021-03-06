/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace BerkeleyDB.Internal {

using System;
using System.Runtime.InteropServices;

internal class DB_PREPLIST : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DB_PREPLIST(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DB_PREPLIST obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DB_PREPLIST() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libdb_csharpPINVOKE.delete_DB_PREPLIST(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  internal DB_TXN txn {
    get {
      IntPtr cPtr = libdb_csharpPINVOKE.DB_PREPLIST_txn_get(swigCPtr);
      DB_TXN ret = (cPtr == IntPtr.Zero) ? null : new DB_TXN(cPtr, false);
      return ret;
    } 
  }

  internal byte[] gid {
        get {
          byte[] ret = new byte[DbConstants.DB_GID_SIZE];
	  IntPtr cPtr = new IntPtr(swigCPtr.Handle.ToInt32() + IntPtr.Size);
	  Marshal.Copy(cPtr, ret, 0, ret.Length);
	  return ret;
        }
	
  }

  internal DB_PREPLIST() : this(libdb_csharpPINVOKE.new_DB_PREPLIST(), true) {
  }

}

}
