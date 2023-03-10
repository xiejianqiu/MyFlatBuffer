// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ShenShouEquipLevelUp : Table {
  public static FB_ShenShouEquipLevelUp GetRootAsFB_ShenShouEquipLevelUp(ByteBuffer _bb) { return GetRootAsFB_ShenShouEquipLevelUp(_bb, new FB_ShenShouEquipLevelUp()); }
  public static FB_ShenShouEquipLevelUp GetRootAsFB_ShenShouEquipLevelUp(ByteBuffer _bb, FB_ShenShouEquipLevelUp obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ShenShouEquipLevelUp __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Exp { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Quality { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenShouEquipLevelUp> CreateFB_ShenShouEquipLevelUp(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset Name = default(StringOffset),
      int Exp = -1,
      int Quality = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_ShenShouEquipLevelUp.AddAttrValueList(builder, AttrValueList);
    FB_ShenShouEquipLevelUp.AddAttrIdList(builder, AttrIdList);
    FB_ShenShouEquipLevelUp.AddQuality(builder, Quality);
    FB_ShenShouEquipLevelUp.AddExp(builder, Exp);
    FB_ShenShouEquipLevelUp.AddName(builder, Name);
    FB_ShenShouEquipLevelUp.AddID(builder, ID);
    return FB_ShenShouEquipLevelUp.EndFB_ShenShouEquipLevelUp(builder);
  }

  public static void StartFB_ShenShouEquipLevelUp(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddExp(FlatBufferBuilder builder, int Exp) { builder.AddInt(2, Exp, -1); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(3, Quality, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(4, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(5, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenShouEquipLevelUp> EndFB_ShenShouEquipLevelUp(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenShouEquipLevelUp>(o);
  }
};

public sealed class FB_ShenShouEquipLevelUpContainer : Table {
  public static FB_ShenShouEquipLevelUpContainer GetRootAsFB_ShenShouEquipLevelUpContainer(ByteBuffer _bb) { return GetRootAsFB_ShenShouEquipLevelUpContainer(_bb, new FB_ShenShouEquipLevelUpContainer()); }
  public static FB_ShenShouEquipLevelUpContainer GetRootAsFB_ShenShouEquipLevelUpContainer(ByteBuffer _bb, FB_ShenShouEquipLevelUpContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ShenShouEquipLevelUpContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ShenShouEquipLevelUpContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ShenShouEquipLevelUp GetItems(int j) { return GetItems(new FB_ShenShouEquipLevelUp(), j); }
  public FB_ShenShouEquipLevelUp GetItems(FB_ShenShouEquipLevelUp obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ShenShouEquipLevelUpContainer> CreateFB_ShenShouEquipLevelUpContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ShenShouEquipLevelUpContainer.AddItems(builder, items);
    return FB_ShenShouEquipLevelUpContainer.EndFB_ShenShouEquipLevelUpContainer(builder);
  }

  public static void StartFB_ShenShouEquipLevelUpContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ShenShouEquipLevelUp>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ShenShouEquipLevelUpContainer> EndFB_ShenShouEquipLevelUpContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ShenShouEquipLevelUpContainer>(o);
  }
  public static void FinishFB_ShenShouEquipLevelUpContainerBuffer(FlatBufferBuilder builder, Offset<FB_ShenShouEquipLevelUpContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
