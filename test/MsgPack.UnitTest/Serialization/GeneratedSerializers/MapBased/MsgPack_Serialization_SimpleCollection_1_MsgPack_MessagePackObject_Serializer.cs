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
    public class MsgPack_Serialization_SimpleCollection_1_MsgPack_MessagePackObject_Serializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject>> {
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject> _serializer0;
        
        public MsgPack_Serialization_SimpleCollection_1_MsgPack_MessagePackObject_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<MsgPack.MessagePackObject>(schema0);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject> objectTree) {
            packer.PackArrayHeader(objectTree.Count);
            System.Collections.Generic.IEnumerator<MsgPack.MessagePackObject> enumerator = objectTree.GetEnumerator();
            MsgPack.MessagePackObject current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    this._serializer0.PackTo(packer, current);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        protected internal override MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject> collection = default(MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject>);
            collection = new MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject>();
            this.UnpackToCore(unpacker, collection);
            return collection;
        }
        
        protected internal override void UnpackToCore(MsgPack.Unpacker unpacker, MsgPack.Serialization.SimpleCollection<MsgPack.MessagePackObject> collection) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            int count = default(int);
            count = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            for (int i = 0; (i < count); i = (i + 1)) {
                MsgPack.MessagePackObject nullable = default(MsgPack.MessagePackObject);
                if ((unpacker.Read() == false)) {
                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                }
                if (((unpacker.IsArrayHeader == false) 
                            && (unpacker.IsMapHeader == false))) {
                    nullable = unpacker.LastReadData;
                }
                else {
                    nullable = unpacker.UnpackSubtreeData();
                }
                if ((nullable.IsNil == false)) {
                    collection.Add(nullable);
                }
                else {
                    collection.Add(nullable);
                }
            }
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
