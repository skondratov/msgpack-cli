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
    public class System_Collections_ObjectModel_ObservableCollection_1_System_Int32_Serializer : MsgPack.Serialization.MessagePackSerializer<System.Collections.ObjectModel.ObservableCollection<int>> {
        
        private MsgPack.Serialization.MessagePackSerializer<int> _serializer0;
        
        public System_Collections_ObjectModel_ObservableCollection_1_System_Int32_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            schema0 = null;
            this._serializer0 = context.GetSerializer<int>(schema0);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, System.Collections.ObjectModel.ObservableCollection<int> objectTree) {
            packer.PackArrayHeader(objectTree.Count);
            System.Collections.Generic.IEnumerator<int> enumerator = objectTree.GetEnumerator();
            int current;
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
        
        protected internal override System.Collections.ObjectModel.ObservableCollection<int> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            System.Collections.ObjectModel.ObservableCollection<int> collection = default(System.Collections.ObjectModel.ObservableCollection<int>);
            collection = new System.Collections.ObjectModel.ObservableCollection<int>();
            this.UnpackToCore(unpacker, collection);
            return collection;
        }
        
        protected internal override void UnpackToCore(MsgPack.Unpacker unpacker, System.Collections.ObjectModel.ObservableCollection<int> collection) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            int count = default(int);
            count = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            for (int i = 0; (i < count); i = (i + 1)) {
                System.Nullable<int> nullable = default(System.Nullable<int>);
                nullable = MsgPack.Serialization.UnpackHelpers.UnpackNullableInt32Value(unpacker, typeof(System.Collections.ObjectModel.ObservableCollection<int>), string.Format(System.Globalization.CultureInfo.InvariantCulture, "item{0}", new object[] {
                                ((object)(i))}));
                if (nullable.HasValue) {
                    collection.Add(nullable.Value);
                }
                else {
                    throw MsgPack.Serialization.SerializationExceptions.NewValueTypeCannotBeNull(string.Format(System.Globalization.CultureInfo.InvariantCulture, "item{0}", new object[] {
                                    ((object)(i))}), typeof(int), typeof(System.Collections.ObjectModel.ObservableCollection<int>));
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
