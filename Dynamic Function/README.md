# Dynamic-Function
The shared library allocating an executable heap, you can read, write or execute
some object code at runtime with this project.

# Interfaces
The infrastructures, fn_malloc, fn_realloc and fn_free are used for directly get
accessing the executable heap. The specializes including struct argument_traits,
function_proto and function_traits deduce from a concrete function type with a
calling convention involved all the argument types in parameter list and its
return type. The struct make_function_type backs to the its concrete function
type from its template arguments. The fn_call likewise what we have std::invoke
transfers control from an arbitrary type pointer. The functionalities consist of
struct byte and function. The struct byte overrides operator new and delete
through the allocations to wrap the executable heap.

# Implementations
In x86 mode, functions as such with thiscall likewise what we have in fastcall,
while both the callee the responsibility to clean up the stack for arguments
passed through by the caller, but fastcall using both ecx and edx registers pass
through the first 2 dword arguments while thiscall only using ecx register pass
through that pointer. As we inject the 2nd parameter of type 'int' to shift the
legacy of the parameters all pushed onto the stack if needed, whenever functions
are invoked where the edx register left as unspecified, preventing the abuse of
injection on object codes or inline assembly. The variadic calls propagating the
arguments, the cdecl requires caller clean up the stack for parameter passing.
The rest just clean up inside callee by the last ret instruction with offset.

In x64 mode, such functions with thiscall is same as cdecl, while the this
argument treated as the first implicit parameter in which that pointer is
correspondence with rcx register to pass through with the default x64 calling
convention. The rest other than vectorcall also comply with the default x64
calling convention to which the program may propagate the arguments with
variadic calls.

Calling Convention Constants
* c_decl = 0
* stdcall = 1
* fastcall = 2
* thiscall = 3
* vectorcall = 4

In the context of the language C, function arguments are pushed on the stack in
the right-to-left order.

The cdecl may be used for variadic functions while others are not.

In x86 mode, the caller shall clean up the stack for function arguments only for
cdecl while others are the callee responsible. In x64 mode, the caller shall
clean up the stack for function arguments.

x86 / x64 Return From Procedure (Near)
* C3 ret
* C2 ret imm16

They just pop the return address from the stack and set the instruction pointer
to it, and the 2nd one will then pop imm16 bytes from the stack.

In x86 mode, the fastcall uses ecx and edx registers to pass the first 2 dword
in the argument list from left to right, while the thiscall uses ecx register to
pass the this pointer, and the rest of them are passed on the stack.

In x64 mode, the x64 default fastcall calling convention requires a different
stack usage to x86 mode, where the first 4 arguments in the argument list from
left to right are passed in RCX (or XMM0 for floating point), RDX (or XMM1 for
floating point), R8 (or XMM2 for floating point), and R9 (or XMM3 for floating
point). The rest of the arguments are passed on the stack.
