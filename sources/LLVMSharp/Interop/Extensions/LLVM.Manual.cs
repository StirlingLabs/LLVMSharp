// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/llvm/llvm-project/tree/llvmorg-14.0.0/llvm/include/llvm-c
// Original source is Copyright (c) the LLVM Project and Contributors. Licensed under the Apache License v2.0 with LLVM Exceptions. See NOTICE.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace LLVMSharp.Interop
{
    public static unsafe partial class LLVM
    {
        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAArch64TargetInfo", ExactSpelling = true)]
        public static extern void InitializeAArch64TargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAMDGPUTargetInfo", ExactSpelling = true)]
        public static extern void InitializeAMDGPUTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeARMTargetInfo", ExactSpelling = true)]
        public static extern void InitializeARMTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAVRTargetInfo", ExactSpelling = true)]
        public static extern void InitializeAVRTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeBPFTargetInfo", ExactSpelling = true)]
        public static extern void InitializeBPFTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeHexagonTargetInfo", ExactSpelling = true)]
        public static extern void InitializeHexagonTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeLanaiTargetInfo", ExactSpelling = true)]
        public static extern void InitializeLanaiTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMipsTargetInfo", ExactSpelling = true)]
        public static extern void InitializeMipsTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMSP430TargetInfo", ExactSpelling = true)]
        public static extern void InitializeMSP430TargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeNVPTXTargetInfo", ExactSpelling = true)]
        public static extern void InitializeNVPTXTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializePowerPCTargetInfo", ExactSpelling = true)]
        public static extern void InitializePowerPCTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeRISCVTargetInfo", ExactSpelling = true)]
        public static extern void InitializeRISCVTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSparcTargetInfo", ExactSpelling = true)]
        public static extern void InitializeSparcTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSystemZTargetInfo", ExactSpelling = true)]
        public static extern void InitializeSystemZTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeVETargetInfo", ExactSpelling = true)]
        public static extern void InitializeVETargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeWebAssemblyTargetInfo", ExactSpelling = true)]
        public static extern void InitializeWebAssemblyTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeX86TargetInfo", ExactSpelling = true)]
        public static extern void InitializeX86TargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeXCoreTargetInfo", ExactSpelling = true)]
        public static extern void InitializeXCoreTargetInfo();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAArch64Target", ExactSpelling = true)]
        public static extern void InitializeAArch64Target();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAMDGPUTarget", ExactSpelling = true)]
        public static extern void InitializeAMDGPUTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeARMTarget", ExactSpelling = true)]
        public static extern void InitializeARMTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAVRTarget", ExactSpelling = true)]
        public static extern void InitializeAVRTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeBPFTarget", ExactSpelling = true)]
        public static extern void InitializeBPFTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeHexagonTarget", ExactSpelling = true)]
        public static extern void InitializeHexagonTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeLanaiTarget", ExactSpelling = true)]
        public static extern void InitializeLanaiTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMipsTarget", ExactSpelling = true)]
        public static extern void InitializeMipsTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMSP430Target", ExactSpelling = true)]
        public static extern void InitializeMSP430Target();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeNVPTXTarget", ExactSpelling = true)]
        public static extern void InitializeNVPTXTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializePowerPCTarget", ExactSpelling = true)]
        public static extern void InitializePowerPCTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeRISCVTarget", ExactSpelling = true)]
        public static extern void InitializeRISCVTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSparcTarget", ExactSpelling = true)]
        public static extern void InitializeSparcTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSystemZTarget", ExactSpelling = true)]
        public static extern void InitializeSystemZTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeVETarget", ExactSpelling = true)]
        public static extern void InitializeVETarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeWebAssemblyTarget", ExactSpelling = true)]
        public static extern void InitializeWebAssemblyTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeX86Target", ExactSpelling = true)]
        public static extern void InitializeX86Target();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeXCoreTarget", ExactSpelling = true)]
        public static extern void InitializeXCoreTarget();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAArch64TargetMC", ExactSpelling = true)]
        public static extern void InitializeAArch64TargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAMDGPUTargetMC", ExactSpelling = true)]
        public static extern void InitializeAMDGPUTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeARMTargetMC", ExactSpelling = true)]
        public static extern void InitializeARMTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAVRTargetMC", ExactSpelling = true)]
        public static extern void InitializeAVRTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeBPFTargetMC", ExactSpelling = true)]
        public static extern void InitializeBPFTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeHexagonTargetMC", ExactSpelling = true)]
        public static extern void InitializeHexagonTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeLanaiTargetMC", ExactSpelling = true)]
        public static extern void InitializeLanaiTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMipsTargetMC", ExactSpelling = true)]
        public static extern void InitializeMipsTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMSP430TargetMC", ExactSpelling = true)]
        public static extern void InitializeMSP430TargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeNVPTXTargetMC", ExactSpelling = true)]
        public static extern void InitializeNVPTXTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializePowerPCTargetMC", ExactSpelling = true)]
        public static extern void InitializePowerPCTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeRISCVTargetMC", ExactSpelling = true)]
        public static extern void InitializeRISCVTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSparcTargetMC", ExactSpelling = true)]
        public static extern void InitializeSparcTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSystemZTargetMC", ExactSpelling = true)]
        public static extern void InitializeSystemZTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeVETargetMC", ExactSpelling = true)]
        public static extern void InitializeVETargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeWebAssemblyTargetMC", ExactSpelling = true)]
        public static extern void InitializeWebAssemblyTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeX86TargetMC", ExactSpelling = true)]
        public static extern void InitializeX86TargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeXCoreTargetMC", ExactSpelling = true)]
        public static extern void InitializeXCoreTargetMC();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAArch64AsmPrinter", ExactSpelling = true)]
        public static extern void InitializeAArch64AsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAMDGPUAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeAMDGPUAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeARMAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeARMAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAVRAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeAVRAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeBPFAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeBPFAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeHexagonAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeHexagonAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeLanaiAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeLanaiAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMipsAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeMipsAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMSP430AsmPrinter", ExactSpelling = true)]
        public static extern void InitializeMSP430AsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeNVPTXAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeNVPTXAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializePowerPCAsmPrinter", ExactSpelling = true)]
        public static extern void InitializePowerPCAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeRISCVAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeRISCVAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSparcAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeSparcAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSystemZAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeSystemZAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeVEAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeVEAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeWebAssemblyAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeWebAssemblyAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeX86AsmPrinter", ExactSpelling = true)]
        public static extern void InitializeX86AsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeXCoreAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeXCoreAsmPrinter();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAArch64AsmParser", ExactSpelling = true)]
        public static extern void InitializeAArch64AsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAMDGPUAsmParser", ExactSpelling = true)]
        public static extern void InitializeAMDGPUAsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeARMAsmParser", ExactSpelling = true)]
        public static extern void InitializeARMAsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAVRAsmParser", ExactSpelling = true)]
        public static extern void InitializeAVRAsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeBPFAsmParser", ExactSpelling = true)]
        public static extern void InitializeBPFAsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeHexagonAsmParser", ExactSpelling = true)]
        public static extern void InitializeHexagonAsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeLanaiAsmParser", ExactSpelling = true)]
        public static extern void InitializeLanaiAsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMipsAsmParser", ExactSpelling = true)]
        public static extern void InitializeMipsAsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMSP430AsmParser", ExactSpelling = true)]
        public static extern void InitializeMSP430AsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializePowerPCAsmParser", ExactSpelling = true)]
        public static extern void InitializePowerPCAsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeRISCVAsmParser", ExactSpelling = true)]
        public static extern void InitializeRISCVAsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSparcAsmParser", ExactSpelling = true)]
        public static extern void InitializeSparcAsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSystemZAsmParser", ExactSpelling = true)]
        public static extern void InitializeSystemZAsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeVEAsmParser", ExactSpelling = true)]
        public static extern void InitializeVEAsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeWebAssemblyAsmParser", ExactSpelling = true)]
        public static extern void InitializeWebAssemblyAsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeX86AsmParser", ExactSpelling = true)]
        public static extern void InitializeX86AsmParser();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAArch64Disassembler", ExactSpelling = true)]
        public static extern void InitializeAArch64Disassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAMDGPUDisassembler", ExactSpelling = true)]
        public static extern void InitializeAMDGPUDisassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeARMDisassembler", ExactSpelling = true)]
        public static extern void InitializeARMDisassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAVRDisassembler", ExactSpelling = true)]
        public static extern void InitializeAVRDisassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeBPFDisassembler", ExactSpelling = true)]
        public static extern void InitializeBPFDisassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeHexagonDisassembler", ExactSpelling = true)]
        public static extern void InitializeHexagonDisassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeLanaiDisassembler", ExactSpelling = true)]
        public static extern void InitializeLanaiDisassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMipsDisassembler", ExactSpelling = true)]
        public static extern void InitializeMipsDisassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMSP430Disassembler", ExactSpelling = true)]
        public static extern void InitializeMSP430Disassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializePowerPCDisassembler", ExactSpelling = true)]
        public static extern void InitializePowerPCDisassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeRISCVDisassembler", ExactSpelling = true)]
        public static extern void InitializeRISCVDisassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSparcDisassembler", ExactSpelling = true)]
        public static extern void InitializeSparcDisassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSystemZDisassembler", ExactSpelling = true)]
        public static extern void InitializeSystemZDisassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeVEDisassembler", ExactSpelling = true)]
        public static extern void InitializeVEDisassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeWebAssemblyDisassembler", ExactSpelling = true)]
        public static extern void InitializeWebAssemblyDisassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeX86Disassembler", ExactSpelling = true)]
        public static extern void InitializeX86Disassembler();

        [DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeXCoreDisassembler", ExactSpelling = true)]
        public static extern void InitializeXCoreDisassembler();
    }
}
