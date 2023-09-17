// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_SkillSkinBase : Table {
  public static FB_SkillSkinBase GetRootAsFB_SkillSkinBase(ByteBuffer _bb) { return GetRootAsFB_SkillSkinBase(_bb, new FB_SkillSkinBase()); }
  public static FB_SkillSkinBase GetRootAsFB_SkillSkinBase(ByteBuffer _bb, FB_SkillSkinBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_SkillSkinBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string UnlockDesc { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetFakeObjIDList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FakeObjIDListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int MaxAP { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string NameSprite { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_SkillSkinBase> CreateFB_SkillSkinBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset UnlockDesc = default(StringOffset),
      VectorOffset FakeObjIDList = default(VectorOffset),
      int MaxAP = -1,
      StringOffset NameSprite = default(StringOffset)) {
    builder.StartObject(5);
    FB_SkillSkinBase.AddNameSprite(builder, NameSprite);
    FB_SkillSkinBase.AddMaxAP(builder, MaxAP);
    FB_SkillSkinBase.AddFakeObjIDList(builder, FakeObjIDList);
    FB_SkillSkinBase.AddUnlockDesc(builder, UnlockDesc);
    FB_SkillSkinBase.AddId(builder, Id);
    return FB_SkillSkinBase.EndFB_SkillSkinBase(builder);
  }

  public static void StartFB_SkillSkinBase(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddUnlockDesc(FlatBufferBuilder builder, StringOffset UnlockDescOffset) { builder.AddOffset(1, UnlockDescOffset.Value, 0); }
  public static void AddFakeObjIDList(FlatBufferBuilder builder, VectorOffset FakeObjIDListOffset) { builder.AddOffset(2, FakeObjIDListOffset.Value, 0); }
  public static VectorOffset CreateFakeObjIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFakeObjIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMaxAP(FlatBufferBuilder builder, int MaxAP) { builder.AddInt(3, MaxAP, -1); }
  public static void AddNameSprite(FlatBufferBuilder builder, StringOffset NameSpriteOffset) { builder.AddOffset(4, NameSpriteOffset.Value, 0); }
  public static Offset<FB_SkillSkinBase> EndFB_SkillSkinBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillSkinBase>(o);
  }
};

public sealed class FB_SkillSkinBaseContainer : Table {
  public static FB_SkillSkinBaseContainer GetRootAsFB_SkillSkinBaseContainer(ByteBuffer _bb) { return GetRootAsFB_SkillSkinBaseContainer(_bb, new FB_SkillSkinBaseContainer()); }
  public static FB_SkillSkinBaseContainer GetRootAsFB_SkillSkinBaseContainer(ByteBuffer _bb, FB_SkillSkinBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SkillSkinBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SkillSkinBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_SkillSkinBase GetItems(int j) { return GetItems(new FB_SkillSkinBase(), j); }
  public FB_SkillSkinBase GetItems(FB_SkillSkinBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SkillSkinBaseContainer> CreateFB_SkillSkinBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SkillSkinBaseContainer.AddItems(builder, items);
    return FB_SkillSkinBaseContainer.EndFB_SkillSkinBaseContainer(builder);
  }

  public static void StartFB_SkillSkinBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_SkillSkinBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SkillSkinBaseContainer> EndFB_SkillSkinBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SkillSkinBaseContainer>(o);
  }
  public static void FinishFB_SkillSkinBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_SkillSkinBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
