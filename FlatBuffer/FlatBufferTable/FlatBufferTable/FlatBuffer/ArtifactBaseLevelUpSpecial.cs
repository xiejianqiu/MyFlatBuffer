// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ArtifactBaseLevelUpSpecial : Table {
  public static FB_ArtifactBaseLevelUpSpecial GetRootAsFB_ArtifactBaseLevelUpSpecial(ByteBuffer _bb) { return GetRootAsFB_ArtifactBaseLevelUpSpecial(_bb, new FB_ArtifactBaseLevelUpSpecial()); }
  public static FB_ArtifactBaseLevelUpSpecial GetRootAsFB_ArtifactBaseLevelUpSpecial(ByteBuffer _bb, FB_ArtifactBaseLevelUpSpecial obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ArtifactBaseLevelUpSpecial __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public long Exp { get { int o = __offset(6); return o != 0 ? bb.GetLong(o + bb_pos) : (long)-1; } }
  public int GetAttrIdList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ArtifactBaseLevelUpSpecial> CreateFB_ArtifactBaseLevelUpSpecial(FlatBufferBuilder builder,
      int Id = 0,
      long Exp = -1,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(4);
    FB_ArtifactBaseLevelUpSpecial.AddExp(builder, Exp);
    FB_ArtifactBaseLevelUpSpecial.AddAttrValueList(builder, AttrValueList);
    FB_ArtifactBaseLevelUpSpecial.AddAttrIdList(builder, AttrIdList);
    FB_ArtifactBaseLevelUpSpecial.AddId(builder, Id);
    return FB_ArtifactBaseLevelUpSpecial.EndFB_ArtifactBaseLevelUpSpecial(builder);
  }

  public static void StartFB_ArtifactBaseLevelUpSpecial(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddExp(FlatBufferBuilder builder, long Exp) { builder.AddLong(1, Exp, -1); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(2, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(3, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ArtifactBaseLevelUpSpecial> EndFB_ArtifactBaseLevelUpSpecial(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ArtifactBaseLevelUpSpecial>(o);
  }
};

public sealed class FB_ArtifactBaseLevelUpSpecialContainer : Table {
  public static FB_ArtifactBaseLevelUpSpecialContainer GetRootAsFB_ArtifactBaseLevelUpSpecialContainer(ByteBuffer _bb) { return GetRootAsFB_ArtifactBaseLevelUpSpecialContainer(_bb, new FB_ArtifactBaseLevelUpSpecialContainer()); }
  public static FB_ArtifactBaseLevelUpSpecialContainer GetRootAsFB_ArtifactBaseLevelUpSpecialContainer(ByteBuffer _bb, FB_ArtifactBaseLevelUpSpecialContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ArtifactBaseLevelUpSpecialContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ArtifactBaseLevelUpSpecialContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ArtifactBaseLevelUpSpecial GetItems(int j) { return GetItems(new FB_ArtifactBaseLevelUpSpecial(), j); }
  public FB_ArtifactBaseLevelUpSpecial GetItems(FB_ArtifactBaseLevelUpSpecial obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ArtifactBaseLevelUpSpecialContainer> CreateFB_ArtifactBaseLevelUpSpecialContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ArtifactBaseLevelUpSpecialContainer.AddItems(builder, items);
    return FB_ArtifactBaseLevelUpSpecialContainer.EndFB_ArtifactBaseLevelUpSpecialContainer(builder);
  }

  public static void StartFB_ArtifactBaseLevelUpSpecialContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ArtifactBaseLevelUpSpecial>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ArtifactBaseLevelUpSpecialContainer> EndFB_ArtifactBaseLevelUpSpecialContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ArtifactBaseLevelUpSpecialContainer>(o);
  }
  public static void FinishFB_ArtifactBaseLevelUpSpecialContainerBuffer(FlatBufferBuilder builder, Offset<FB_ArtifactBaseLevelUpSpecialContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
