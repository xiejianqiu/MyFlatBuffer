// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChapterCardLevelUp : Table {
  public static FB_ChapterCardLevelUp GetRootAsFB_ChapterCardLevelUp(ByteBuffer _bb) { return GetRootAsFB_ChapterCardLevelUp(_bb, new FB_ChapterCardLevelUp()); }
  public static FB_ChapterCardLevelUp GetRootAsFB_ChapterCardLevelUp(ByteBuffer _bb, FB_ChapterCardLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChapterCardLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CardID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelUpNeedCount { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrTypeList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrTypeListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChapterCardLevelUp> CreateFB_ChapterCardLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      int CardID = -1,
      int Quality = -1,
      int LevelUpNeedCount = -1,
      VectorOffset AttrTypeList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_ChapterCardLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_ChapterCardLevelUp.AddAttrTypeList(builder, AttrTypeList);
    FB_ChapterCardLevelUp.AddLevelUpNeedCount(builder, LevelUpNeedCount);
    FB_ChapterCardLevelUp.AddQuality(builder, Quality);
    FB_ChapterCardLevelUp.AddCardID(builder, CardID);
    FB_ChapterCardLevelUp.AddID(builder, ID);
    return FB_ChapterCardLevelUp.EndFB_ChapterCardLevelUp(builder);
  }

  public static void StartFB_ChapterCardLevelUp(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddCardID(FlatBufferBuilder builder, int CardID) { builder.AddInt(1, CardID, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(2, Quality, -1); }
  public static void AddLevelUpNeedCount(FlatBufferBuilder builder, int LevelUpNeedCount) { builder.AddInt(3, LevelUpNeedCount, -1); }
  public static void AddAttrTypeList(FlatBufferBuilder builder, VectorOffset AttrTypeListOffset) { builder.AddOffset(4, AttrTypeListOffset.Value, 0); }
  public static VectorOffset CreateAttrTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChapterCardLevelUp> EndFB_ChapterCardLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChapterCardLevelUp>(o);
  }
};

public sealed class FB_ChapterCardLevelUpContainer : Table {
  public static FB_ChapterCardLevelUpContainer GetRootAsFB_ChapterCardLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_ChapterCardLevelUpContainer(_bb, new FB_ChapterCardLevelUpContainer()); }
  public static FB_ChapterCardLevelUpContainer GetRootAsFB_ChapterCardLevelUpContainer(ByteBuffer _bb, FB_ChapterCardLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChapterCardLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChapterCardLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChapterCardLevelUp GetItems(int j) { return GetItems(new FB_ChapterCardLevelUp(), j); }
  public FB_ChapterCardLevelUp GetItems(FB_ChapterCardLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChapterCardLevelUpContainer> CreateFB_ChapterCardLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChapterCardLevelUpContainer.AddItems(builder, items);
    return FB_ChapterCardLevelUpContainer.EndFB_ChapterCardLevelUpContainer(builder);
  }

  public static void StartFB_ChapterCardLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChapterCardLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChapterCardLevelUpContainer> EndFB_ChapterCardLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChapterCardLevelUpContainer>(o);
  }
  public static void FinishFB_ChapterCardLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChapterCardLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
