// Generated by Haxe 3.4.7
using haxe.root;

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace sys.io {
	public class FileInput : global::cs.io.NativeInput {
		
		public FileInput(global::haxe.lang.EmptyObject empty) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
		}
		
		
		public FileInput(global::System.IO.FileStream stream) : base(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) )) {
			global::sys.io.FileInput.__hx_ctor_sys_io_FileInput(this, stream);
		}
		
		
		public static void __hx_ctor_sys_io_FileInput(global::sys.io.FileInput __hx_this, global::System.IO.FileStream stream) {
			global::cs.io.NativeInput.__hx_ctor_cs_io_NativeInput(__hx_this, stream);
		}
		
		
	}
}


