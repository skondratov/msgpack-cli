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
    public class MsgPack_Serialization_SimpleCollection_1_System_DateTime_Serializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.SimpleCollection<System.DateTime>> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.DateTime>> _serializer1;
        
        public MsgPack_Serialization_SimpleCollection_1_System_DateTime_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<System.DateTime>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            schema1 = null;
            this._serializer1 = context.GetSerializer<System.Nullable<System.DateTime>>(schema1);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.SimpleCollection<System.DateTime> objectTree) {
            packer.PackArrayHeader(objectTree.Count);
            System.Collections.Generic.IEnumerator<System.DateTime> enumerator = objectTree.GetEnumerator();
            System.DateTime current;
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
        
        protected internal override MsgPack.Serialization.SimpleCollection<System.DateTime> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            MsgPack.Serialization.SimpleCollection<System.DateTime> collection = default(MsgPack.Serialization.SimpleCollection<System.DateTime>);
            collection = new MsgPack.Serialization.SimpleCollection<System.DateTime>();
            this.UnpackToCore(unpacker, collection);
            return collection;
        }
        
        protected internal override void UnpackToCore(MsgPack.Unpacker unpacker, MsgPack.Serialization.SimpleCollection<System.DateTime> collection) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            int count = default(int);
            count = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            for (int i = 0; (i < count); i = (i + 1)) {
                System.Nullable<System.DateTime> nullable = default(System.Nullable<System.DateTime>);
                if ((unpacker.Read() == false)) {
                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                }
                if (((unpacker.IsArrayHeader == false) 
                            && (unpacker.IsMapHeader == false))) {
                    nullable = this._serializer1.UnpackFrom(unpacker);
                }
                else {
                    MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                    disposable = unpacker.ReadSubtree();
                    try {
                        nullable = this._serializer1.UnpackFrom(disposable);
                    }
                    finally {
                        if (((disposable == null) 
                                    == false)) {
                            disposable.Dispose();
                        }
                    }
                }
                if (nullable.HasValue) {
                    collection.Add(nullable.Value);
                }
                else {
                    throw MsgPack.Serialization.SerializationExceptions.NewValueTypeCannotBeNull(string.Format(System.Globalization.CultureInfo.InvariantCulture, "item{0}", new object[] {
                                    ((object)(i))}), typeof(System.DateTime), typeof(MsgPack.Serialization.SimpleCollection<System.DateTime>));
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
