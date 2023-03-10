// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_JiBanAttrLevelUp : Table {
  public static FB_JiBanAttrLevelUp GetRootAsFB_JiBanAttrLevelUp(ByteBuffer _bb) { return GetRootAsFB_JiBanAttrLevelUp(_bb, new FB_JiBanAttrLevelUp()); }
  public static FB_JiBanAttrLevelUp GetRootAsFB_JiBanAttrLevelUp(ByteBuffer _bb, FB_JiBanAttrLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_JiBanAttrLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string JiBanID { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Quality { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetAttrTypeList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrTypeListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiBanAttrLevelUp> CreateFB_JiBanAttrLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset JiBanID = default(StringOffset),
      int Quality = -1,
      VectorOffset AttrTypeList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(5);
    FB_JiBanAttrLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_JiBanAttrLevelUp.AddAttrTypeList(builder, AttrTypeList);
    FB_JiBanAttrLevelUp.AddQuality(builder, Quality);
    FB_JiBanAttrLevelUp.AddJiBanID(builder, JiBanID);
    FB_JiBanAttrLevelUp.AddID(builder, ID);
    return FB_JiBanAttrLevelUp.EndFB_JiBanAttrLevelUp(builder);
  }

  public static void StartFB_JiBanAttrLevelUp(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddJiBanID(FlatBufferBuilder builder, StringOffset JiBanIDOffset) { builder.AddOffset(1, JiBanIDOffset.Value, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(2, Quality, -1); }
  public static void AddAttrTypeList(FlatBufferBuilder builder, VectorOffset AttrTypeListOffset) { builder.AddOffset(3, AttrTypeListOffset.Value, 0); }
  public static VectorOffset CreateAttrTypeListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrTypeListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(4, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiBanAttrLevelUp> EndFB_JiBanAttrLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiBanAttrLevelUp>(o);
  }
};

public sealed class FB_JiBanAttrLevelUpContainer : Table {
  public static FB_JiBanAttrLevelUpContainer GetRootAsFB_JiBanAttrLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_JiBanAttrLevelUpContainer(_bb, new FB_JiBanAttrLevelUpContainer()); }
  public static FB_JiBanAttrLevelUpContainer GetRootAsFB_JiBanAttrLevelUpContainer(ByteBuffer _bb, FB_JiBanAttrLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_JiBanAttrLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_JiBanAttrLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_JiBanAttrLevelUp GetItems(int j) { return GetItems(new FB_JiBanAttrLevelUp(), j); }
  public FB_JiBanAttrLevelUp GetItems(FB_JiBanAttrLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_JiBanAttrLevelUpContainer> CreateFB_JiBanAttrLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_JiBanAttrLevelUpContainer.AddItems(builder, items);
    return FB_JiBanAttrLevelUpContainer.EndFB_JiBanAttrLevelUpContainer(builder);
  }

  public static void StartFB_JiBanAttrLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_JiBanAttrLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_JiBanAttrLevelUpContainer> EndFB_JiBanAttrLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_JiBanAttrLevelUpContainer>(o);
  }
  public static void FinishFB_JiBanAttrLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_JiBanAttrLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
