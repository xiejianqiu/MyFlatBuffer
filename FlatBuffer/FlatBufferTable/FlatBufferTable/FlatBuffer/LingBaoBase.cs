// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LingBaoBase : Table {
  public static FB_LingBaoBase GetRootAsFB_LingBaoBase(ByteBuffer _bb) { return GetRootAsFB_LingBaoBase(_bb, new FB_LingBaoBase()); }
  public static FB_LingBaoBase GetRootAsFB_LingBaoBase(ByteBuffer _bb, FB_LingBaoBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LingBaoBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string NameSprite { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FakeObjId { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Quality { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Type { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockParam { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockParamSec { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetAttrIdList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrIdListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttrValueList(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttrValueListLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public int GetAttValueMaxList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AttValueMaxListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingBaoBase> CreateFB_LingBaoBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset NameSprite = default(StringOffset),
      int FakeObjId = 0,
      int Quality = 0,
      int Type = 0,
      int UnlockType = 0,
      int UnlockParam = 0,
      int UnlockParamSec = 0,
      VectorOffset AttrIdList = default(VectorOffset),
      VectorOffset AttrValueList = default(VectorOffset),
      VectorOffset AttValueMaxList = default(VectorOffset)) {
    builder.StartObject(12);
    FB_LingBaoBase.AddAttValueMaxList(builder, AttValueMaxList);
    FB_LingBaoBase.AddAttrValueList(builder, AttrValueList);
    FB_LingBaoBase.AddAttrIdList(builder, AttrIdList);
    FB_LingBaoBase.AddUnlockParamSec(builder, UnlockParamSec);
    FB_LingBaoBase.AddUnlockParam(builder, UnlockParam);
    FB_LingBaoBase.AddUnlockType(builder, UnlockType);
    FB_LingBaoBase.AddType(builder, Type);
    FB_LingBaoBase.AddQuality(builder, Quality);
    FB_LingBaoBase.AddFakeObjId(builder, FakeObjId);
    FB_LingBaoBase.AddNameSprite(builder, NameSprite);
    FB_LingBaoBase.AddName(builder, Name);
    FB_LingBaoBase.AddId(builder, Id);
    return FB_LingBaoBase.EndFB_LingBaoBase(builder);
  }

  public static void StartFB_LingBaoBase(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddNameSprite(FlatBufferBuilder builder, StringOffset NameSpriteOffset) { builder.AddOffset(2, NameSpriteOffset.Value, 0); }
  public static void AddFakeObjId(FlatBufferBuilder builder, int FakeObjId) { builder.AddInt(3, FakeObjId, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(4, Quality, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(5, Type, 0); }
  public static void AddUnlockType(FlatBufferBuilder builder, int UnlockType) { builder.AddInt(6, UnlockType, 0); }
  public static void AddUnlockParam(FlatBufferBuilder builder, int UnlockParam) { builder.AddInt(7, UnlockParam, 0); }
  public static void AddUnlockParamSec(FlatBufferBuilder builder, int UnlockParamSec) { builder.AddInt(8, UnlockParamSec, 0); }
  public static void AddAttrIdList(FlatBufferBuilder builder, VectorOffset AttrIdListOffset) { builder.AddOffset(9, AttrIdListOffset.Value, 0); }
  public static VectorOffset CreateAttrIdListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrIdListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttrValueList(FlatBufferBuilder builder, VectorOffset AttrValueListOffset) { builder.AddOffset(10, AttrValueListOffset.Value, 0); }
  public static VectorOffset CreateAttrValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttrValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAttValueMaxList(FlatBufferBuilder builder, VectorOffset AttValueMaxListOffset) { builder.AddOffset(11, AttValueMaxListOffset.Value, 0); }
  public static VectorOffset CreateAttValueMaxListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAttValueMaxListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingBaoBase> EndFB_LingBaoBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingBaoBase>(o);
  }
};

public sealed class FB_LingBaoBaseContainer : Table {
  public static FB_LingBaoBaseContainer GetRootAsFB_LingBaoBaseContainer(ByteBuffer _bb) { return GetRootAsFB_LingBaoBaseContainer(_bb, new FB_LingBaoBaseContainer()); }
  public static FB_LingBaoBaseContainer GetRootAsFB_LingBaoBaseContainer(ByteBuffer _bb, FB_LingBaoBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LingBaoBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LingBaoBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LingBaoBase GetItems(int j) { return GetItems(new FB_LingBaoBase(), j); }
  public FB_LingBaoBase GetItems(FB_LingBaoBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LingBaoBaseContainer> CreateFB_LingBaoBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LingBaoBaseContainer.AddItems(builder, items);
    return FB_LingBaoBaseContainer.EndFB_LingBaoBaseContainer(builder);
  }

  public static void StartFB_LingBaoBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LingBaoBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LingBaoBaseContainer> EndFB_LingBaoBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LingBaoBaseContainer>(o);
  }
  public static void FinishFB_LingBaoBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_LingBaoBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
