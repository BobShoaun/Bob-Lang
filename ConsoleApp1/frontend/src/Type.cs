using LLVMSharp;

public enum Type {
    Integer16,
    Integer32,
    Integer64,
    Float16,
    Float32,
    Float64,
    Float128,
    String,
    Boolean,
    Void
}

public class TypeHelper {

    public static Type GetType(string type) {
        switch (type) {
            case "short":
            case "int16":
            case "integer16":
                return Type.Integer16;
            case "int":
            case "integer":
            case "int32":
            case "integer32":
                return Type.Integer32;
            case "long":
            case "int64":
            case "integer64":
                return Type.Integer64;
            case "half":
            case "float16":
                return Type.Float16;
            case "single":
            case "float":
            case "float32":
                return Type.Float32;
            case "double":
            case "float64":
                return Type.Float64;
            case "decimal":
            case "float128":
                return Type.Float128;
            case "string":
                return Type.String;
            case "bool":
                return Type.Boolean;
            case "void":
                return Type.Void;
            default:
                throw new System.Exception($"Unknown type {type}");
        }
    }

    public static LLVMTypeRef GetLLVMType(Type type) {
        switch (type) {
            case Type.Integer16:
                return LLVM.Int16Type();
            case Type.Integer32:
                return LLVM.Int32Type();
            case Type.Integer64:
                return LLVM.Int64Type();
            case Type.Float16:
                return LLVM.HalfType();
            case Type.Float32:
                return LLVM.FloatType();
            case Type.Float64:
                return LLVM.DoubleType();
            case Type.Float128:
                return LLVM.X86FP80Type();
            case Type.String:
                return LLVM.PointerType(LLVM.Int8Type(), 0);
            case Type.Boolean:
                return LLVM.Int1Type();
            case Type.Void:
                return LLVM.VoidType();
            default:
                throw new System.Exception($"Unknown type {type}");
        }
    }

}