﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34209
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_ComplexTypeGeneratedEnclosureSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeGeneratedEnclosure> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.ComplexTypeGenerated> _serializer1;
        
        public MsgPack_Serialization_ComplexTypeGeneratedEnclosureSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<MsgPack.Serialization.ComplexTypeGenerated>(schema1);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.ComplexTypeGeneratedEnclosure objectTree) {
            packer.PackMapHeader(2);
            this._serializer0.PackTo(packer, "Name");
            this._serializer0.PackTo(packer, objectTree.Name);
            this._serializer0.PackTo(packer, "Nested");
            this._serializer1.PackTo(packer, objectTree.Nested);
        }
        
        protected internal override MsgPack.Serialization.ComplexTypeGeneratedEnclosure UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.ComplexTypeGeneratedEnclosure result = default(MsgPack.Serialization.ComplexTypeGeneratedEnclosure);
            result = new MsgPack.Serialization.ComplexTypeGeneratedEnclosure();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                string nullable = default(string);
                if ((unpacked < itemsCount)) {
                    nullable = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeGeneratedEnclosure), "System.String Name");
                }
                if (((nullable == null) 
                            == false)) {
                    result.Name = nullable;
                }
                unpacked = (unpacked + 1);
                MsgPack.Serialization.ComplexTypeGenerated nullable0 = default(MsgPack.Serialization.ComplexTypeGenerated);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(1);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable0 = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable0 = this._serializer1.UnpackFrom(disposable);
                        }
                        finally {
                            if (((disposable == null) 
                                        == false)) {
                                disposable.Dispose();
                            }
                        }
                    }
                }
                if (((nullable0 == null) 
                            == false)) {
                    result.Nested = nullable0;
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable1 = default(string);
                    nullable1 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeGeneratedEnclosure), "MemberName");
                    if (((nullable1 == null) 
                                == false)) {
                        key = nullable1;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "Nested")) {
                        MsgPack.Serialization.ComplexTypeGenerated nullable3 = default(MsgPack.Serialization.ComplexTypeGenerated);
                        if ((unpacker.Read() == false)) {
                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                        }
                        if (((unpacker.IsArrayHeader == false) 
                                    && (unpacker.IsMapHeader == false))) {
                            nullable3 = this._serializer1.UnpackFrom(unpacker);
                        }
                        else {
                            MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                            disposable0 = unpacker.ReadSubtree();
                            try {
                                nullable3 = this._serializer1.UnpackFrom(disposable0);
                            }
                            finally {
                                if (((disposable0 == null) 
                                            == false)) {
                                    disposable0.Dispose();
                                }
                            }
                        }
                        if (((nullable3 == null) 
                                    == false)) {
                            result.Nested = nullable3;
                        }
                    }
                    else {
                        if ((key == "Name")) {
                            string nullable2 = default(string);
                            nullable2 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.ComplexTypeGeneratedEnclosure), "System.String Name");
                            if (((nullable2 == null) 
                                        == false)) {
                                result.Name = nullable2;
                            }
                        }
                        else {
                            unpacker.Skip();
                        }
                    }
                }
            }
            return result;
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
