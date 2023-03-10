// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingMapBase : Table {
  public static FB_JiLingMapBase GetRootAsFB_JiLingMapBase(ByteBuffer _bb) { return GetRootAsFB_JiLingMapBase(_bb, new FB_JiLingMapBase()); }
  public static FB_JiLingMapBase GetRootAsFB_JiLingMapBase(ByteBuffer _bb, FB_JiLingMapBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingMapBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int MaPexplain { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DoubleRewIndex { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetItemIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetItemNumList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ItemNumListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingMapBase> CreateFB_JiLingMapBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int MaPexplain = -1,
      int DoubleRewIndex = -1,
      VectorOffset ItemIdList = default(VectorOffset),
      VectorOffset ItemNumList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_JiLingMapBase.AddItemNumList(builder, ItemNumList);
    FB_JiLingMapBase.AddItemIdList(builder, ItemIdList);
    FB_JiLingMapBase.AddDoubleRewIndex(builder, DoubleRewIndex);
    FB_JiLingMapBase.AddMaPexplain(builder, MaPexplain);
    FB_JiLingMapBase.AddName(builder, Name);
    FB_JiLingMapBase.AddID(builder, ID);
    return FB_JiLingMapBase.EndFB_JiLingMapBase(builder);
  }

  public static void StartFB_JiLingMapBase(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddMaPexplain(FlatBufferBuilder builder, int MaPexplain) { builder.AddInt(2, MaPexplain, -1); }
  public static void AddDoubleRewIndex(FlatBufferBuilder builder, int DoubleRewIndex) { builder.AddInt(3, DoubleRewIndex, -1); }
  public static void AddItemIdList(FlatBufferBuilder builder, VectorOffset ItemIdListOffset) { builder.AddOffset(4, ItemIdListOffset.Value, 0); }
  public static VectorOffset CreateItemIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddItemNumList(FlatBufferBuilder builder, VectorOffset ItemNumListOffset) { builder.AddOffset(5, ItemNumListOffset.Value, 0); }
  public static VectorOffset CreateItemNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartItemNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingMapBase> EndFB_JiLingMapBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingMapBase>(o);
  }
};

public sealed class FB_JiLingMapBaseContainer : Table {
  public static FB_JiLingMapBaseContainer GetRootAsFB_JiLingMapBaseContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingMapBaseContainer(_bb, new FB_JiLingMapBaseContainer()); }
  public static FB_JiLingMapBaseContainer GetRootAsFB_JiLingMapBaseContainer(ByteBuffer _bb, FB_JiLingMapBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingMapBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingMapBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingMapBase GetItems(int j) { return GetItems(new FB_JiLingMapBase(), j); }
  public FB_JiLingMapBase GetItems(FB_JiLingMapBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingMapBaseContainer> CreateFB_JiLingMapBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingMapBaseContainer.AddItems(builder, items);
    return FB_JiLingMapBaseContainer.EndFB_JiLingMapBaseContainer(builder);
  }

  public static void StartFB_JiLingMapBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingMapBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingMapBaseContainer> EndFB_JiLingMapBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingMapBaseContainer>(o);
  }
  public static void FinishFB_JiLingMapBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingMapBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
