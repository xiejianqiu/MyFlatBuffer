// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ZhanLingLibao : Table {
  public static FB_ZhanLingLibao GetRootAsFB_ZhanLingLibao(ByteBuffer _bb) { return GetRootAsFB_ZhanLingLibao(_bb, new FB_ZhanLingLibao()); }
  public static FB_ZhanLingLibao GetRootAsFB_ZhanLingLibao(ByteBuffer _bb, FB_ZhanLingLibao obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ZhanLingLibao __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Days { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ConsumeMoney { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ConsumeYuanBao { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemIDGudingList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIDGudingListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumGudingList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumGudingListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ZhanLingLibao> CreateFB_ZhanLingLibao(FlatBufferBuilder builder,
      int ID = 0,
      int Type = -1,
      int Days = -1,
      int ConsumeMoney = -1,
      int ConsumeYuanBao = -1,
      VectorOffset ItemIDList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset),
      VectorOffset ItemIDGudingList = default(VectorOffset),
      VectorOffset ItemNumGudingList = default(VectorOffset)) {
    builder.StartObject(9);
    FB_ZhanLingLibao.AddItemNumGudingList(builder, ItemNumGudingList);
    FB_ZhanLingLibao.AddItemIDGudingList(builder, ItemIDGudingList);
    FB_ZhanLingLibao.AddItemNumList(builder, ItemNumList);
    FB_ZhanLingLibao.AddItemIDList(builder, ItemIDList);
    FB_ZhanLingLibao.AddConsumeYuanBao(builder, ConsumeYuanBao);
    FB_ZhanLingLibao.AddConsumeMoney(builder, ConsumeMoney);
    FB_ZhanLingLibao.AddDays(builder, Days);
    FB_ZhanLingLibao.AddType(builder, Type);
    FB_ZhanLingLibao.AddID(builder, ID);
    return FB_ZhanLingLibao.EndFB_ZhanLingLibao(builder);
  }

  public static void StartFB_ZhanLingLibao(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(1, Type, -1); }
  public static void AddDays(FlatBufferBuilder builder, int Days) { builder.AddInt(2, Days, -1); }
  public static void AddConsumeMoney(FlatBufferBuilder builder, int ConsumeMoney) { builder.AddInt(3, ConsumeMoney, -1); }
  public static void AddConsumeYuanBao(FlatBufferBuilder builder, int ConsumeYuanBao) { builder.AddInt(4, ConsumeYuanBao, -1); }
  public static void AddItemIDList(FlatBufferBuilder builder, VectorOffset ItemIDListOffset) { builder.AddOffset(5, ItemIDListOffset.Value, 0); }
  public static VectorOffset CreateItemIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(6, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemIDGudingList(FlatBufferBuilder builder, VectorOffset ItemIDGudingListOffset) { builder.AddOffset(7, ItemIDGudingListOffset.Value, 0); }
  public static VectorOffset CreateItemIDGudingListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIDGudingListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumGudingList(FlatBufferBuilder builder, VectorOffset ItemNumGudingListOffset) { builder.AddOffset(8, ItemNumGudingListOffset.Value, 0); }
  public static VectorOffset CreateItemNumGudingListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumGudingListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ZhanLingLibao> EndFB_ZhanLingLibao(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ZhanLingLibao>(o);
  }
};

public sealed class FB_ZhanLingLibaoContainer : Table {
  public static FB_ZhanLingLibaoContainer GetRootAsFB_ZhanLingLibaoContainer(ByteBuffer _bb) { return GetRootAsFB_ZhanLingLibaoContainer(_bb, new FB_ZhanLingLibaoContainer()); }
  public static FB_ZhanLingLibaoContainer GetRootAsFB_ZhanLingLibaoContainer(ByteBuffer _bb, FB_ZhanLingLibaoContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ZhanLingLibaoContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ZhanLingLibaoContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ZhanLingLibao GetItems(int j) { return GetItems(new FB_ZhanLingLibao(), j); }
  public FB_ZhanLingLibao GetItems(FB_ZhanLingLibao obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ZhanLingLibaoContainer> CreateFB_ZhanLingLibaoContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ZhanLingLibaoContainer.AddItems(builder, items);
    return FB_ZhanLingLibaoContainer.EndFB_ZhanLingLibaoContainer(builder);
  }

  public static void StartFB_ZhanLingLibaoContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ZhanLingLibao>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ZhanLingLibaoContainer> EndFB_ZhanLingLibaoContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ZhanLingLibaoContainer>(o);
  }
  public static void FinishFB_ZhanLingLibaoContainerBuffer(FlatBufferBuilder builder, Offset<FB_ZhanLingLibaoContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
