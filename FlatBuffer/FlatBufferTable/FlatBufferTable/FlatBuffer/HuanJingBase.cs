// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_HuanJingBase : Table {
  public static FB_HuanJingBase GetRootAsFB_HuanJingBase(ByteBuffer _bb) { return GetRootAsFB_HuanJingBase(_bb, new FB_HuanJingBase()); }
  public static FB_HuanJingBase GetRootAsFB_HuanJingBase(ByteBuffer _bb, FB_HuanJingBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_HuanJingBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int TypeMini { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Modle { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int Quality { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockType { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockParam { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockParamSec { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string HuanJingEquip { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool HuanJingJiBan { get { int o = __offset(24); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public string GetIconButtonList(int j) { int o = __offset(26); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int IconButtonListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public string Icon { get { int o = __offset(28); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FakeObjId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string StoryTitle { get { int o = __offset(32); return o != 0 ? __string(o + bb_pos) : null; } }
  public string StoryInfo { get { int o = __offset(34); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_HuanJingBase> CreateFB_HuanJingBase(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      int Type = 0,
      int TypeMini = 0,
      int Modle = 0,
      int Quality = 0,
      int UnlockType = 0,
      int UnlockParam = 0,
      int UnlockParamSec = 0,
      StringOffset HuanJingEquip = default(StringOffset),
      bool HuanJingJiBan = false,
      VectorOffset IconButtonList = default(VectorOffset),
      StringOffset Icon = default(StringOffset),
      int FakeObjId = 0,
      StringOffset StoryTitle = default(StringOffset),
      StringOffset StoryInfo = default(StringOffset)) {
    builder.StartObject(16);
    FB_HuanJingBase.AddStoryInfo(builder, StoryInfo);
    FB_HuanJingBase.AddStoryTitle(builder, StoryTitle);
    FB_HuanJingBase.AddFakeObjId(builder, FakeObjId);
    FB_HuanJingBase.AddIcon(builder, Icon);
    FB_HuanJingBase.AddIconButtonList(builder, IconButtonList);
    FB_HuanJingBase.AddHuanJingEquip(builder, HuanJingEquip);
    FB_HuanJingBase.AddUnlockParamSec(builder, UnlockParamSec);
    FB_HuanJingBase.AddUnlockParam(builder, UnlockParam);
    FB_HuanJingBase.AddUnlockType(builder, UnlockType);
    FB_HuanJingBase.AddQuality(builder, Quality);
    FB_HuanJingBase.AddModle(builder, Modle);
    FB_HuanJingBase.AddTypeMini(builder, TypeMini);
    FB_HuanJingBase.AddType(builder, Type);
    FB_HuanJingBase.AddName(builder, Name);
    FB_HuanJingBase.AddId(builder, Id);
    FB_HuanJingBase.AddHuanJingJiBan(builder, HuanJingJiBan);
    return FB_HuanJingBase.EndFB_HuanJingBase(builder);
  }

  public static void StartFB_HuanJingBase(FlatBufferBuilder builder) { builder.StartObject(16); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(2, Type, 0); }
  public static void AddTypeMini(FlatBufferBuilder builder, int TypeMini) { builder.AddInt(3, TypeMini, 0); }
  public static void AddModle(FlatBufferBuilder builder, int Modle) { builder.AddInt(4, Modle, 0); }
  public static void AddQuality(FlatBufferBuilder builder, int Quality) { builder.AddInt(5, Quality, 0); }
  public static void AddUnlockType(FlatBufferBuilder builder, int UnlockType) { builder.AddInt(6, UnlockType, 0); }
  public static void AddUnlockParam(FlatBufferBuilder builder, int UnlockParam) { builder.AddInt(7, UnlockParam, 0); }
  public static void AddUnlockParamSec(FlatBufferBuilder builder, int UnlockParamSec) { builder.AddInt(8, UnlockParamSec, 0); }
  public static void AddHuanJingEquip(FlatBufferBuilder builder, StringOffset HuanJingEquipOffset) { builder.AddOffset(9, HuanJingEquipOffset.Value, 0); }
  public static void AddHuanJingJiBan(FlatBufferBuilder builder, bool HuanJingJiBan) { builder.AddBool(10, HuanJingJiBan, false); }
  public static void AddIconButtonList(FlatBufferBuilder builder, VectorOffset IconButtonListOffset) { builder.AddOffset(11, IconButtonListOffset.Value, 0); }
  public static VectorOffset CreateIconButtonListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartIconButtonListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(12, IconOffset.Value, 0); }
  public static void AddFakeObjId(FlatBufferBuilder builder, int FakeObjId) { builder.AddInt(13, FakeObjId, 0); }
  public static void AddStoryTitle(FlatBufferBuilder builder, StringOffset StoryTitleOffset) { builder.AddOffset(14, StoryTitleOffset.Value, 0); }
  public static void AddStoryInfo(FlatBufferBuilder builder, StringOffset StoryInfoOffset) { builder.AddOffset(15, StoryInfoOffset.Value, 0); }
  public static Offset<FB_HuanJingBase> EndFB_HuanJingBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingBase>(o);
  }
};

public sealed class FB_HuanJingBaseContainer : Table {
  public static FB_HuanJingBaseContainer GetRootAsFB_HuanJingBaseContainer(ByteBuffer _bb) { return GetRootAsFB_HuanJingBaseContainer(_bb, new FB_HuanJingBaseContainer()); }
  public static FB_HuanJingBaseContainer GetRootAsFB_HuanJingBaseContainer(ByteBuffer _bb, FB_HuanJingBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_HuanJingBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_HuanJingBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_HuanJingBase GetItems(int j) { return GetItems(new FB_HuanJingBase(), j); }
  public FB_HuanJingBase GetItems(FB_HuanJingBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_HuanJingBaseContainer> CreateFB_HuanJingBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_HuanJingBaseContainer.AddItems(builder, items);
    return FB_HuanJingBaseContainer.EndFB_HuanJingBaseContainer(builder);
  }

  public static void StartFB_HuanJingBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_HuanJingBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_HuanJingBaseContainer> EndFB_HuanJingBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_HuanJingBaseContainer>(o);
  }
  public static void FinishFB_HuanJingBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_HuanJingBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
