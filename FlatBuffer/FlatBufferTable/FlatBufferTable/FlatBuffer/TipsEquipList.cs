// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TipsEquipList : Table {
  public static FB_TipsEquipList GetRootAsFB_TipsEquipList(ByteBuffer _bb) { return GetRootAsFB_TipsEquipList(_bb, new FB_TipsEquipList()); }
  public static FB_TipsEquipList GetRootAsFB_TipsEquipList(ByteBuffer _bb, FB_TipsEquipList obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TipsEquipList __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetUseParamList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int UseParamListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TipsEquipList> CreateFB_TipsEquipList(FlatBufferBuilder builder,
      int Id = 0,
      VectorOffset UseParamList = default(VectorOffset)) {
    builder.StartObject(2);
    FB_TipsEquipList.AddUseParamList(builder, UseParamList);
    FB_TipsEquipList.AddId(builder, Id);
    return FB_TipsEquipList.EndFB_TipsEquipList(builder);
  }

  public static void StartFB_TipsEquipList(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddUseParamList(FlatBufferBuilder builder, VectorOffset UseParamListOffset) { builder.AddOffset(1, UseParamListOffset.Value, 0); }
  public static VectorOffset CreateUseParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartUseParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TipsEquipList> EndFB_TipsEquipList(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TipsEquipList>(o);
  }
};

public sealed class FB_TipsEquipListContainer : Table {
  public static FB_TipsEquipListContainer GetRootAsFB_TipsEquipListContainer(ByteBuffer _bb) { return GetRootAsFB_TipsEquipListContainer(_bb, new FB_TipsEquipListContainer()); }
  public static FB_TipsEquipListContainer GetRootAsFB_TipsEquipListContainer(ByteBuffer _bb, FB_TipsEquipListContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TipsEquipListContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TipsEquipListContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TipsEquipList GetItems(int j) { return GetItems(new FB_TipsEquipList(), j); }
  public FB_TipsEquipList GetItems(FB_TipsEquipList obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TipsEquipListContainer> CreateFB_TipsEquipListContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TipsEquipListContainer.AddItems(builder, items);
    return FB_TipsEquipListContainer.EndFB_TipsEquipListContainer(builder);
  }

  public static void StartFB_TipsEquipListContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TipsEquipList>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TipsEquipListContainer> EndFB_TipsEquipListContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TipsEquipListContainer>(o);
  }
  public static void FinishFB_TipsEquipListContainerBuffer(FlatBufferBuilder builder, Offset<FB_TipsEquipListContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
