﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.7.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_AddOnlyCollection_1_System_DateTimeArray_Serializer : MsgPack.Serialization.CollectionSerializers.EnumerableMessagePackSerializer<MsgPack.Serialization.AddOnlyCollection<System.DateTime[]>, System.DateTime[]> {
        
        private System.Action<MsgPack.Unpacker, MsgPack.Serialization.AddOnlyCollection<System.DateTime[]>, int> _unpackTo;
        
        private System.Func<MsgPack.Unpacker, MsgPack.Serialization.AddOnlyCollection<System.DateTime[]>, int, System.Threading.CancellationToken, System.Threading.Tasks.Task> _unpackToAsync;
        
        public MsgPack_Serialization_AddOnlyCollection_1_System_DateTimeArray_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, MsgPack_Serialization_AddOnlyCollection_1_System_DateTimeArray_Serializer.RestoreSchema()) {
            this._unpackTo = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.AddOnlyCollection<System.DateTime[]>, int>(this.UnpackToCore);
            this._unpackToAsync = new System.Func<MsgPack.Unpacker, MsgPack.Serialization.AddOnlyCollection<System.DateTime[]>, int, System.Threading.CancellationToken, System.Threading.Tasks.Task>(this.UnpackToAsyncCore);
        }
        
        protected override MsgPack.Serialization.AddOnlyCollection<System.DateTime[]> CreateInstance(int initialCapacity) {
            MsgPack.Serialization.AddOnlyCollection<System.DateTime[]> collection = default(MsgPack.Serialization.AddOnlyCollection<System.DateTime[]>);
            collection = new MsgPack.Serialization.AddOnlyCollection<System.DateTime[]>();
            return collection;
        }
        
        protected override void AddItem(MsgPack.Serialization.AddOnlyCollection<System.DateTime[]> collection, System.DateTime[] item) {
            collection.Add(item);
        }
        
        protected internal override MsgPack.Serialization.AddOnlyCollection<System.DateTime[]> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowIsNotArrayHeader(unpacker);
            }
            int itemsCount = default(int);
            itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            return MsgPack.Serialization.UnpackHelpers.UnpackCollection<MsgPack.Serialization.AddOnlyCollection<System.DateTime[]>>(unpacker, itemsCount, this.CreateInstance(itemsCount), this._unpackTo, null);
        }
        
        protected internal override System.Threading.Tasks.Task<MsgPack.Serialization.AddOnlyCollection<System.DateTime[]>> UnpackFromAsyncCore(MsgPack.Unpacker unpacker, System.Threading.CancellationToken cancellationToken) {
            if ((unpacker.IsArrayHeader == false)) {
                MsgPack.Serialization.SerializationExceptions.ThrowIsNotArrayHeader(unpacker);
            }
            int itemsCount = default(int);
            itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            return MsgPack.Serialization.UnpackHelpers.UnpackCollectionAsync<MsgPack.Serialization.AddOnlyCollection<System.DateTime[]>>(unpacker, itemsCount, this.CreateInstance(itemsCount), this._unpackToAsync, null, cancellationToken);
        }
        
        private static MsgPack.Serialization.PolymorphismSchema RestoreSchema() {
            MsgPack.Serialization.PolymorphismSchema schema = default(MsgPack.Serialization.PolymorphismSchema);
            schema = null;
            return schema;
        }
    }
}
