﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34209
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_EnumByteFlagsSerializer : MsgPack.Serialization.EnumMessagePackSerializer<MsgPack.Serialization.EnumByteFlags> {
        
        public MsgPack_Serialization_EnumByteFlagsSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, MsgPack.Serialization.EnumSerializationMethod.ByName) {
        }
        
        protected internal override void PackUnderlyingValueTo(MsgPack.Packer packer, MsgPack.Serialization.EnumByteFlags enumValue) {
            packer.Pack(((byte)(enumValue)));
        }
        
        protected internal override MsgPack.Serialization.EnumByteFlags UnpackFromUnderlyingValue(MsgPack.MessagePackObject messagePackObject) {
            return ((MsgPack.Serialization.EnumByteFlags)(messagePackObject.AsByte()));
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
