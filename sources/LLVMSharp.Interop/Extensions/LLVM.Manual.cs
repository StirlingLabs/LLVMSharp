// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from https://github.com/llvm/llvm-project/tree/llvmorg-14.0.0/llvm/include/llvm-c
// Original source is Copyright (c) the LLVM Project and Contributors. Licensed under the Apache License v2.0 with LLVM Exceptions. See NOTICE.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace LLVMSharp.Interop
{
    public static unsafe partial class LLVM
    {
        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAArch64TargetInfo", ExactSpelling = true)]
        public static extern void InitializeAArch64TargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAMDGPUTargetInfo", ExactSpelling = true)]
        public static extern void InitializeAMDGPUTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeARMTargetInfo", ExactSpelling = true)]
        public static extern void InitializeARMTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAVRTargetInfo", ExactSpelling = true)]
        public static extern void InitializeAVRTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeBPFTargetInfo", ExactSpelling = true)]
        public static extern void InitializeBPFTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeHexagonTargetInfo", ExactSpelling = true)]
        public static extern void InitializeHexagonTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeLanaiTargetInfo", ExactSpelling = true)]
        public static extern void InitializeLanaiTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMipsTargetInfo", ExactSpelling = true)]
        public static extern void InitializeMipsTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMSP430TargetInfo", ExactSpelling = true)]
        public static extern void InitializeMSP430TargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeNVPTXTargetInfo", ExactSpelling = true)]
        public static extern void InitializeNVPTXTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializePowerPCTargetInfo", ExactSpelling = true)]
        public static extern void InitializePowerPCTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeRISCVTargetInfo", ExactSpelling = true)]
        public static extern void InitializeRISCVTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSparcTargetInfo", ExactSpelling = true)]
        public static extern void InitializeSparcTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSystemZTargetInfo", ExactSpelling = true)]
        public static extern void InitializeSystemZTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeVETargetInfo", ExactSpelling = true)]
        public static extern void InitializeVETargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeWebAssemblyTargetInfo", ExactSpelling = true)]
        public static extern void InitializeWebAssemblyTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeX86TargetInfo", ExactSpelling = true)]
        public static extern void InitializeX86TargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeXCoreTargetInfo", ExactSpelling = true)]
        public static extern void InitializeXCoreTargetInfo();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAArch64Target", ExactSpelling = true)]
        public static extern void InitializeAArch64Target();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAMDGPUTarget", ExactSpelling = true)]
        public static extern void InitializeAMDGPUTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeARMTarget", ExactSpelling = true)]
        public static extern void InitializeARMTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAVRTarget", ExactSpelling = true)]
        public static extern void InitializeAVRTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeBPFTarget", ExactSpelling = true)]
        public static extern void InitializeBPFTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeHexagonTarget", ExactSpelling = true)]
        public static extern void InitializeHexagonTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeLanaiTarget", ExactSpelling = true)]
        public static extern void InitializeLanaiTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMipsTarget", ExactSpelling = true)]
        public static extern void InitializeMipsTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMSP430Target", ExactSpelling = true)]
        public static extern void InitializeMSP430Target();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeNVPTXTarget", ExactSpelling = true)]
        public static extern void InitializeNVPTXTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializePowerPCTarget", ExactSpelling = true)]
        public static extern void InitializePowerPCTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeRISCVTarget", ExactSpelling = true)]
        public static extern void InitializeRISCVTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSparcTarget", ExactSpelling = true)]
        public static extern void InitializeSparcTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSystemZTarget", ExactSpelling = true)]
        public static extern void InitializeSystemZTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeVETarget", ExactSpelling = true)]
        public static extern void InitializeVETarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeWebAssemblyTarget", ExactSpelling = true)]
        public static extern void InitializeWebAssemblyTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeX86Target", ExactSpelling = true)]
        public static extern void InitializeX86Target();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeXCoreTarget", ExactSpelling = true)]
        public static extern void InitializeXCoreTarget();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAArch64TargetMC", ExactSpelling = true)]
        public static extern void InitializeAArch64TargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAMDGPUTargetMC", ExactSpelling = true)]
        public static extern void InitializeAMDGPUTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeARMTargetMC", ExactSpelling = true)]
        public static extern void InitializeARMTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAVRTargetMC", ExactSpelling = true)]
        public static extern void InitializeAVRTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeBPFTargetMC", ExactSpelling = true)]
        public static extern void InitializeBPFTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeHexagonTargetMC", ExactSpelling = true)]
        public static extern void InitializeHexagonTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeLanaiTargetMC", ExactSpelling = true)]
        public static extern void InitializeLanaiTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMipsTargetMC", ExactSpelling = true)]
        public static extern void InitializeMipsTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMSP430TargetMC", ExactSpelling = true)]
        public static extern void InitializeMSP430TargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeNVPTXTargetMC", ExactSpelling = true)]
        public static extern void InitializeNVPTXTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializePowerPCTargetMC", ExactSpelling = true)]
        public static extern void InitializePowerPCTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeRISCVTargetMC", ExactSpelling = true)]
        public static extern void InitializeRISCVTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSparcTargetMC", ExactSpelling = true)]
        public static extern void InitializeSparcTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSystemZTargetMC", ExactSpelling = true)]
        public static extern void InitializeSystemZTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeVETargetMC", ExactSpelling = true)]
        public static extern void InitializeVETargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeWebAssemblyTargetMC", ExactSpelling = true)]
        public static extern void InitializeWebAssemblyTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeX86TargetMC", ExactSpelling = true)]
        public static extern void InitializeX86TargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeXCoreTargetMC", ExactSpelling = true)]
        public static extern void InitializeXCoreTargetMC();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAArch64AsmPrinter", ExactSpelling = true)]
        public static extern void InitializeAArch64AsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAMDGPUAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeAMDGPUAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeARMAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeARMAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAVRAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeAVRAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeBPFAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeBPFAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeHexagonAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeHexagonAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeLanaiAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeLanaiAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMipsAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeMipsAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMSP430AsmPrinter", ExactSpelling = true)]
        public static extern void InitializeMSP430AsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeNVPTXAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeNVPTXAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializePowerPCAsmPrinter", ExactSpelling = true)]
        public static extern void InitializePowerPCAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeRISCVAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeRISCVAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSparcAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeSparcAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSystemZAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeSystemZAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeVEAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeVEAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeWebAssemblyAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeWebAssemblyAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeX86AsmPrinter", ExactSpelling = true)]
        public static extern void InitializeX86AsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeXCoreAsmPrinter", ExactSpelling = true)]
        public static extern void InitializeXCoreAsmPrinter();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAArch64AsmParser", ExactSpelling = true)]
        public static extern void InitializeAArch64AsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAMDGPUAsmParser", ExactSpelling = true)]
        public static extern void InitializeAMDGPUAsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeARMAsmParser", ExactSpelling = true)]
        public static extern void InitializeARMAsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAVRAsmParser", ExactSpelling = true)]
        public static extern void InitializeAVRAsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeBPFAsmParser", ExactSpelling = true)]
        public static extern void InitializeBPFAsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeHexagonAsmParser", ExactSpelling = true)]
        public static extern void InitializeHexagonAsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeLanaiAsmParser", ExactSpelling = true)]
        public static extern void InitializeLanaiAsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMipsAsmParser", ExactSpelling = true)]
        public static extern void InitializeMipsAsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMSP430AsmParser", ExactSpelling = true)]
        public static extern void InitializeMSP430AsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializePowerPCAsmParser", ExactSpelling = true)]
        public static extern void InitializePowerPCAsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeRISCVAsmParser", ExactSpelling = true)]
        public static extern void InitializeRISCVAsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSparcAsmParser", ExactSpelling = true)]
        public static extern void InitializeSparcAsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSystemZAsmParser", ExactSpelling = true)]
        public static extern void InitializeSystemZAsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeVEAsmParser", ExactSpelling = true)]
        public static extern void InitializeVEAsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeWebAssemblyAsmParser", ExactSpelling = true)]
        public static extern void InitializeWebAssemblyAsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeX86AsmParser", ExactSpelling = true)]
        public static extern void InitializeX86AsmParser();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAArch64Disassembler", ExactSpelling = true)]
        public static extern void InitializeAArch64Disassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAMDGPUDisassembler", ExactSpelling = true)]
        public static extern void InitializeAMDGPUDisassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeARMDisassembler", ExactSpelling = true)]
        public static extern void InitializeARMDisassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeAVRDisassembler", ExactSpelling = true)]
        public static extern void InitializeAVRDisassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeBPFDisassembler", ExactSpelling = true)]
        public static extern void InitializeBPFDisassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeHexagonDisassembler", ExactSpelling = true)]
        public static extern void InitializeHexagonDisassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeLanaiDisassembler", ExactSpelling = true)]
        public static extern void InitializeLanaiDisassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMipsDisassembler", ExactSpelling = true)]
        public static extern void InitializeMipsDisassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeMSP430Disassembler", ExactSpelling = true)]
        public static extern void InitializeMSP430Disassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializePowerPCDisassembler", ExactSpelling = true)]
        public static extern void InitializePowerPCDisassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeRISCVDisassembler", ExactSpelling = true)]
        public static extern void InitializeRISCVDisassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSparcDisassembler", ExactSpelling = true)]
        public static extern void InitializeSparcDisassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeSystemZDisassembler", ExactSpelling = true)]
        public static extern void InitializeSystemZDisassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeVEDisassembler", ExactSpelling = true)]
        public static extern void InitializeVEDisassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeWebAssemblyDisassembler", ExactSpelling = true)]
        public static extern void InitializeWebAssemblyDisassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeX86Disassembler", ExactSpelling = true)]
        public static extern void InitializeX86Disassembler();

        [DllImport("LLVM-14", CallingConvention = CallingConvention.Cdecl, EntryPoint = "LLVMInitializeXCoreDisassembler", ExactSpelling = true)]
        public static extern void InitializeXCoreDisassembler();
    }
}
