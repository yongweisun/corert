// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Reflection;

namespace System
{
    public struct ModuleHandle
    {
        // Public in full framework but not in .NetCore contract
        internal static readonly ModuleHandle EmptyHandle = default(ModuleHandle);

        private Module _ptr;

        internal ModuleHandle(Module module)
        {
            _ptr = module;
        }

        public override int GetHashCode()
        {
            return _ptr != null ? _ptr.GetHashCode() : 0;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is ModuleHandle))
                return false;

            ModuleHandle handle = (ModuleHandle)obj;

            return handle._ptr == _ptr;
        }

        public bool Equals(ModuleHandle handle)
        {
            return handle._ptr == _ptr;
        }

        public RuntimeFieldHandle GetRuntimeFieldHandleFromMetadataToken(int fieldToken)
        {
            throw new PlatformNotSupportedException();
        }

        public RuntimeMethodHandle GetRuntimeMethodHandleFromMetadataToken(int methodToken)
        {
            throw new PlatformNotSupportedException();
        }

        public RuntimeTypeHandle GetRuntimeTypeHandleFromMetadataToken(int typeToken)
        {
            throw new PlatformNotSupportedException();
        }

        public int MDStreamVersion
        {
            get
            {
                throw new PlatformNotSupportedException();
            }
        }

        public static bool operator ==(ModuleHandle left, ModuleHandle right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ModuleHandle left, ModuleHandle right)
        {
            return !left.Equals(right);
        }

        public RuntimeFieldHandle ResolveFieldHandle(int fieldToken)
        {
            throw new PlatformNotSupportedException();
        }

        public RuntimeFieldHandle ResolveFieldHandle(int fieldToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
        {
            throw new PlatformNotSupportedException();
        }

        public RuntimeMethodHandle ResolveMethodHandle(int methodToken)
        {
            throw new PlatformNotSupportedException();
        }

        public RuntimeMethodHandle ResolveMethodHandle(int methodToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
        {
            throw new PlatformNotSupportedException();
        }

        public RuntimeTypeHandle ResolveTypeHandle(int typeToken)
        {
            throw new PlatformNotSupportedException();
        }

        public RuntimeTypeHandle ResolveTypeHandle(int typeToken, RuntimeTypeHandle[] typeInstantiationContext, RuntimeTypeHandle[] methodInstantiationContext)
        {
            throw new PlatformNotSupportedException();
        }
    }
}
