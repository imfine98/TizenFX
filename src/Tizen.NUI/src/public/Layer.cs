/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Tizen.NUI
{
    using System;
    using System.Runtime.InteropServices;
    using Tizen.NUI.BaseComponents;

    /// <summary>
    /// Layers provide a mechanism for overlaying groups of actors on top of each other.
    /// </summary>
    public class Layer : Animatable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal Layer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.Layer_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Layer obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        protected override void Dispose(DisposeTypes type)
        {
            if(disposed)
            {
                return;
            }

            if(type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.
            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicPINVOKE.delete_Layer(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            base.Dispose(type);
        }


        internal class Property : global::System.IDisposable
        {
            private global::System.Runtime.InteropServices.HandleRef swigCPtr;
            protected bool swigCMemOwn;

            internal Property(global::System.IntPtr cPtr, bool cMemoryOwn)
            {
                swigCMemOwn = cMemoryOwn;
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
            }

            internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Property obj)
            {
                return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
            }

            //NUI Dispose Pattern written by Jinwoo Nam(jjw.nam) 

            //A Flag to check who called Dispose(). (By User or DisposeQueue)
            private bool isDisposeQueued = false;
            //A Flat to check if it is already disposed.
            protected bool disposed = false;

            ~Property()
            {
                if(!isDisposeQueued)
                {
                    isDisposeQueued = true;
                    DisposeQueue.Instance.Add(this);
                }
            }

            public void Dispose()
            {
                //Throw excpetion if Dispose() is called in separate thread.
                if (!Window.IsInstalled())
                {
                    throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
                }

                if (isDisposeQueued)
                {
                    Dispose(DisposeTypes.Implicit);
                }
                else
                {
                    Dispose(DisposeTypes.Explicit);
                    System.GC.SuppressFinalize(this);
                }
            }

            protected virtual void Dispose(DisposeTypes type)
            {
                if (disposed)
                {
                    return;
                }

                if(type == DisposeTypes.Explicit)
                {
                    //Called by User
                    //Release your own managed resources here.
                    //You should release all of your own disposable objects here.
                }

                //Release your own unmanaged resources here.
                //You should not access any managed member here except static instance.
                //because the execution order of Finalizes is non-deterministic.

                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        NDalicPINVOKE.delete_Layer_Property(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                disposed = true;
            }

            internal Property() : this(NDalicPINVOKE.new_Layer_Property(), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            internal static readonly int CLIPPING_ENABLE = NDalicPINVOKE.Layer_Property_CLIPPING_ENABLE_get();
            internal static readonly int CLIPPING_BOX = NDalicPINVOKE.Layer_Property_CLIPPING_BOX_get();
            internal static readonly int BEHAVIOR = NDalicPINVOKE.Layer_Property_BEHAVIOR_get();

        }

        /// <summary>
        /// Creates a Layer object.
        /// </summary>
        public Layer() : this(NDalicPINVOKE.Layer_New(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }
        /// <summary>
        /// Downcasts a handle to Layer handle.<br>
        /// If handle points to a Layer, the downcast produces valid handle.<br>
        /// If not, the returned handle is left uninitialized.<br>
        /// </summary>
        /// <param name="handle">Handle to an object</param>
        /// <returns>Handle to a Layer or an uninitialized handle</returns>
        public new static Layer DownCast(BaseHandle handle)
        {
            Layer ret = new Layer(NDalicPINVOKE.Layer_DownCast(BaseHandle.getCPtr(handle)), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal Layer(Layer copy) : this(NDalicPINVOKE.new_Layer__SWIG_1(Layer.getCPtr(copy)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal Layer Assign(Layer rhs)
        {
            Layer ret = new Layer(NDalicPINVOKE.Layer_Assign(swigCPtr, Layer.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Search through this layer's hierarchy for an view with the given unique ID.
        /// </summary>
        /// <pre>This layer(the parent) has been initialized.</pre>
        /// <remarks>The actor itself is also considered in the search.</remarks>
        /// <param name="child">The id of the child to find</param>
        /// <returns> A handle to the view if found, or an empty handle if not. </returns>
        public View FindChildById(uint id)
        {
            View ret = new View(NDalicPINVOKE.Actor_FindChildById(swigCPtr, id), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Adds a child view to this layer.
        /// </summary>
        /// <pre>This layer(the parent) has been initialized. The child view has been initialized. The child view is not the same as the parent layer.</pre>
        /// <post>The child will be referenced by its parent. This means that the child will be kept alive, even if the handle passed into this method is reset or destroyed.</post>
        /// <remarks>If the child already has a parent, it will be removed from old parent and reparented to this layer. This may change child's position, color, scale etc as it now inherits them from this layer.</remarks>
        /// <param name="child">The child</param>
        public void Add(View child)
        {
            NDalicPINVOKE.Actor_Add(swigCPtr, View.getCPtr(child));
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Removes a child View from this layer. If the view was not a child of this layer, this is a no-op.
        /// </summary>
        /// <pre>This layer(the parent) has been initialized. The child view is not the same as the parent view.</pre>
        /// <param name="child">The child</param>
        public void Remove(View child)
        {
            NDalicPINVOKE.Actor_Remove(swigCPtr, View.getCPtr(child));
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Queries the depth of the layer.<br>
        /// 0 is the bottom most layer, higher number is on top.<br>
        /// </summary>
        public uint Depth
        {
            get
            {
                return GetDepth();
            }
        }

        internal uint GetDepth()
        {
            uint ret = NDalicPINVOKE.Layer_GetDepth(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Increments the depth of the layer.
        /// </summary>
        public void Raise()
        {
            NDalicPINVOKE.Layer_Raise(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Decrements the depth of the layer.
        /// </summary>
        public void Lower()
        {
            NDalicPINVOKE.Layer_Lower(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal void RaiseAbove(Layer target)
        {
            NDalicPINVOKE.Layer_RaiseAbove(swigCPtr, Layer.getCPtr(target));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal void LowerBelow(Layer target)
        {
            NDalicPINVOKE.Layer_LowerBelow(swigCPtr, Layer.getCPtr(target));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Raises the layer to the top.
        /// </summary>
        public void RaiseToTop()
        {
            NDalicPINVOKE.Layer_RaiseToTop(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Lowers the layer to the bottom.
        /// </summary>
        public void LowerToBottom()
        {
            NDalicPINVOKE.Layer_LowerToBottom(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Moves the layer directly above the given layer.<br>
        /// After the call, this layers depth will be immediately above target.<br>
        /// </summary>
        /// <param name="target">Layer to get on top of</param>
        public void MoveAbove(Layer target)
        {
            NDalicPINVOKE.Layer_MoveAbove(swigCPtr, Layer.getCPtr(target));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Moves the layer directly below the given layer.<br>
        /// After the call, this layers depth will be immediately below target.<br>
        /// </summary>
        /// <param name="target">Layer to get below of</param>
        public void MoveBelow(Layer target)
        {
            NDalicPINVOKE.Layer_MoveBelow(swigCPtr, Layer.getCPtr(target));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal void SetBehavior(LayerBehavior behavior)
        {
            NDalicPINVOKE.Layer_SetBehavior(swigCPtr, (int)behavior);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal LayerBehavior GetBehavior()
        {
            Layer.LayerBehavior ret = (Layer.LayerBehavior)NDalicPINVOKE.Layer_GetBehavior(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void SetClipping(bool enabled)
        {
            NDalicPINVOKE.Layer_SetClipping(swigCPtr, enabled);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal bool IsClipping()
        {
            bool ret = NDalicPINVOKE.Layer_IsClipping(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void SetClippingBox(int x, int y, int width, int height)
        {
            NDalicPINVOKE.Layer_SetClippingBox__SWIG_0(swigCPtr, x, y, width, height);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Sets the clipping box of a layer, in window coordinates.<br>
        /// The contents of the layer will not be visible outside this box, when clipping is
        /// enabled. The default clipping box is empty (0,0,0,0) which means everything is clipped.<br>
        /// </summary>
        /// <param name="box">The clipping box</param>
        public void SetClippingBox(Rectangle box)
        {
            NDalicPINVOKE.Layer_SetClippingBox__SWIG_1(swigCPtr, Rectangle.getCPtr(box));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Retrieves the clipping box of a layer in window coordinates.
        /// </summary>
        /// <returns>The clipping box</returns>
        public Rectangle GetClippingBox()
        {
            Rectangle ret = new Rectangle(NDalicPINVOKE.Layer_GetClippingBox(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void SetDepthTestDisabled(bool disable)
        {
            NDalicPINVOKE.Layer_SetDepthTestDisabled(swigCPtr, disable);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal bool IsDepthTestDisabled()
        {
            bool ret = NDalicPINVOKE.Layer_IsDepthTestDisabled(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void SetSortFunction(SWIGTYPE_p_f_r_q_const__Dali__Vector3__float function)
        {
            NDalicPINVOKE.Layer_SetSortFunction(swigCPtr, SWIGTYPE_p_f_r_q_const__Dali__Vector3__float.getCPtr(function));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal void SetTouchConsumed(bool consume)
        {
            NDalicPINVOKE.Layer_SetTouchConsumed(swigCPtr, consume);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal bool IsTouchConsumed()
        {
            bool ret = NDalicPINVOKE.Layer_IsTouchConsumed(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void SetHoverConsumed(bool consume)
        {
            NDalicPINVOKE.Layer_SetHoverConsumed(swigCPtr, consume);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal bool IsHoverConsumed()
        {
            bool ret = NDalicPINVOKE.Layer_IsHoverConsumed(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// Retrieves child view by index.
        /// </summary>
        /// <pre>The View has been initialized.</pre>
        /// <param name="index">The index of the child to retrieve</param>
        /// <returns>The view for the given index or empty handle if children not initialized</returns>
        public View GetChildAt(uint index)
        {
            IntPtr cPtr = NDalicPINVOKE.Actor_GetChildAt(swigCPtr, index);
            cPtr = NDalicPINVOKE.View_SWIGUpcast(cPtr);
            cPtr = NDalicPINVOKE.Handle_SWIGUpcast(cPtr);

            BaseHandle ret = new BaseHandle(cPtr, false);

            View temp = ViewRegistry.GetViewFromBaseHandle(ret);

            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();

            return temp ?? null;
        }

        /// <summary>
        /// Enumeration for the behavior of the layer.
        /// </summary>
        public enum LayerBehavior
        {
            Layer2D,
            LayerUI = Layer2D,
            Layer3D
        }

        internal enum TreeDepthMultiplier
        {
            TREE_DEPTH_MULTIPLIER = 10000
        }

        /// <summary>
        /// Layer ClippingEnable, type bool
        /// </summary>
        public bool ClippingEnable
        {
            get
            {
                bool temp = false;
                GetProperty(Layer.Property.CLIPPING_ENABLE).Get(ref temp);
                return temp;
            }
            set
            {
                SetProperty(Layer.Property.CLIPPING_ENABLE, new Tizen.NUI.PropertyValue(value));
            }
        }
        /// <summary>
        /// Layer ClippingBox, type Rectangle
        /// </summary>
        public Rectangle ClippingBox
        {
            get
            {
                Rectangle temp = new Rectangle(0, 0, 0, 0);
                GetProperty(Layer.Property.CLIPPING_BOX).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Layer.Property.CLIPPING_BOX, new Tizen.NUI.PropertyValue(value));
            }
        }
        /// <summary>
        /// Layer Behavior, type String(Layer.LayerBehavior)
        /// </summary>
        public Layer.LayerBehavior Behavior
        {
            get
            {
                return GetBehavior();
            }
            set
            {
                SetBehavior(value);
            }
        }

        /// <summary>
        /// Gets/Sets the Layer's name.
        /// </summary>
        public string Name
        {
            get
            {
                return GetName();
            }
            set
            {
                SetName(value);
            }
        }

        internal string GetName()
        {
            string ret = NDalicPINVOKE.Actor_GetName(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal void SetName(string name)
        {
            NDalicPINVOKE.Actor_SetName(swigCPtr, name);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        /// <summary>
        /// Retrieves the number of children held by the layer.
        /// </summary>
        /// <pre>The layer has been initialized.</pre>
        /// <returns>The number of children</returns>
        public uint GetChildCount()
        {
            uint ret = NDalicPINVOKE.Actor_GetChildCount(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending)
                throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

    }

}
