// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiLingJingJie : Table {
  public static FB_JiLingJingJie GetRootAsFB_JiLingJingJie(ByteBuffer _bb) { return GetRootAsFB_JiLingJingJie(_bb, new FB_JiLingJingJie()); }
  public static FB_JiLingJingJie GetRootAsFB_JiLingJingJie(ByteBuffer _bb, FB_JiLingJingJie obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiLingJingJie __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Level { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int Step { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public int Quality { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public string StepSprite { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Info { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ItemID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ItemCount { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int RealityItemID { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrIDList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIDListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingJingJie> CreateFB_JiLingJingJie(FlatBufferBuilder builder,
      int Id = 0,
      int Level = 1,
      int Step = 1,
      int Quality = 1,
      StringOffset StepSprite = default(StringOffset),
      StringOffset Info = default(StringOffset),
      int ItemID = -1,
      int ItemCount = -1,
      int RealityItemID = -1,
      VectorOffset AttrIDList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(11);
    FB_JiLingJingJie.AddAttrValueList(builder, AttrValueList);
    FB_JiLingJingJie.AddAttrIDList(builder, AttrIDList);
    FB_JiLingJingJie.AddRealityItemID(builder, RealityItemID);
    FB_JiLingJingJie.AddItemCount(builder, ItemCount);
    FB_JiLingJingJie.AddItemID(builder, ItemID);
    FB_JiLingJingJie.AddInfo(builder, Info);
    FB_JiLingJingJie.AddStepSprite(builder, StepSprite);
    FB_JiLingJingJie.AddQuality(builder, Quality);
    FB_JiLingJingJie.AddStep(builder, Step);
    FB_JiLingJingJie.AddLevel(builder, Level);
    FB_JiLingJingJie.AddId(builder, Id);
    return FB_JiLingJingJie.EndFB_JiLingJingJie(builder);
  }

  public static void StartFB_JiLingJingJie(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLevel(FlatBufferBuilder builder, int Level) { builder.AddInt(1, Level, 1); }
  public static void AddStep(FlatBufferBuilder builder, int Step) { builder.AddInt(2, Step, 1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(3, Quality, 1); }
  public static void AddStepSprite(FlatBufferBuilder builder, StringOffset StepSpriteOffset) { builder.AddOffset(4, StepSpriteOffset.Value, 0); }
  public static void AddInfo(FlatBufferBuilder builder, StringOffset InfoOffset) { builder.AddOffset(5, InfoOffset.Value, 0); }
  public static void AddItemID(FlatBufferBuilder builder, int ItemID) { builder.AddInt(6, ItemID, -1); }
  public static void AddItemCount(FlatBufferBuilder builder, int ItemCount) { builder.AddInt(7, ItemCount, -1); }
  public static void AddRealityItemID(FlatBufferBuilder builder, int RealityItemID) { builder.AddInt(8, RealityItemID, -1); }
  public static void AddAttrIDList(FlatBufferBuilder builder, VectorOffset AttrIDListOffset) { builder.AddOffset(9, AttrIDListOffset.Value, 0); }
  public static VectorOffset CreateAttrIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(10, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingJingJie> EndFB_JiLingJingJie(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingJingJie>(o);
  }
};

public sealed class FB_JiLingJingJieContainer : Table {
  public static FB_JiLingJingJieContainer GetRootAsFB_JiLingJingJieContainer(ByteBuffer _bb) { return GetRootAsFB_JiLingJingJieContainer(_bb, new FB_JiLingJingJieContainer()); }
  public static FB_JiLingJingJieContainer GetRootAsFB_JiLingJingJieContainer(ByteBuffer _bb, FB_JiLingJingJieContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiLingJingJieContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiLingJingJieContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiLingJingJie GetItems(int j) { return GetItems(new FB_JiLingJingJie(), j); }
  public FB_JiLingJingJie GetItems(FB_JiLingJingJie obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiLingJingJieContainer> CreateFB_JiLingJingJieContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiLingJingJieContainer.AddItems(builder, items);
    return FB_JiLingJingJieContainer.EndFB_JiLingJingJieContainer(builder);
  }

  public static void StartFB_JiLingJingJieContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiLingJingJie>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiLingJingJieContainer> EndFB_JiLingJingJieContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiLingJingJieContainer>(o);
  }
  public static void FinishFB_JiLingJingJieContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiLingJingJieContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
