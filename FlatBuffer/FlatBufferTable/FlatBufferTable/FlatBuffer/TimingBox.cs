// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_TimingBox : Table {
  public static FB_TimingBox GetRootAsFB_TimingBox(ByteBuffer _bb) { return GetRootAsFB_TimingBox(_bb, new FB_TimingBox()); }
  public static FB_TimingBox GetRootAsFB_TimingBox(ByteBuffer _bb, FB_TimingBox obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_TimingBox __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetBonusTypeList(int j) { int o = __offset(6); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BonusTypeListLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBonusIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BonusIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetBonusNumList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BonusNumListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TimingBox> CreateFB_TimingBox(FlatBufferBuilder builder,
      int ID = 0,
      VectorOffset BonusTypeList = default(VectorOffset),
      VectorOffset BonusIDList = default(VectorOffset),
      VectorOffset BonusNumList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_TimingBox.AddBonusNumList(builder, BonusNumList);
    FB_TimingBox.AddBonusIDList(builder, BonusIDList);
    FB_TimingBox.AddBonusTypeList(builder, BonusTypeList);
    FB_TimingBox.AddID(builder, ID);
    return FB_TimingBox.EndFB_TimingBox(builder);
  }

  public static void StartFB_TimingBox(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddBonusTypeList(FlatBufferBuilder builder, VectorOffset BonusTypeListOffset) { builder.AddOffset(1, BonusTypeListOffset.Value, 0); }
  public static VectorOffset CreateBonusTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBonusTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusIDList(FlatBufferBuilder builder, VectorOffset BonusIDListOffset) { builder.AddOffset(2, BonusIDListOffset.Value, 0); }
  public static VectorOffset CreateBonusIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBonusIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBonusNumList(FlatBufferBuilder builder, VectorOffset BonusNumListOffset) { builder.AddOffset(3, BonusNumListOffset.Value, 0); }
  public static VectorOffset CreateBonusNumListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBonusNumListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TimingBox> EndFB_TimingBox(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TimingBox>(o);
  }
};

public sealed class FB_TimingBoxContainer : Table {
  public static FB_TimingBoxContainer GetRootAsFB_TimingBoxContainer(ByteBuffer _bb) { return GetRootAsFB_TimingBoxContainer(_bb, new FB_TimingBoxContainer()); }
  public static FB_TimingBoxContainer GetRootAsFB_TimingBoxContainer(ByteBuffer _bb, FB_TimingBoxContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_TimingBoxContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_TimingBoxContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_TimingBox GetItems(int j) { return GetItems(new FB_TimingBox(), j); }
  public FB_TimingBox GetItems(FB_TimingBox obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_TimingBoxContainer> CreateFB_TimingBoxContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_TimingBoxContainer.AddItems(builder, items);
    return FB_TimingBoxContainer.EndFB_TimingBoxContainer(builder);
  }

  public static void StartFB_TimingBoxContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_TimingBox>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_TimingBoxContainer> EndFB_TimingBoxContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_TimingBoxContainer>(o);
  }
  public static void FinishFB_TimingBoxContainerBuffer(FlatBufferBuilder builder, Offset<FB_TimingBoxContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
