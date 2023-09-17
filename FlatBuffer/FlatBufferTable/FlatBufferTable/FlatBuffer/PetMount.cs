// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_PetMount : Table {
  public static FB_PetMount GetRootAsFB_PetMount(ByteBuffer _bb) { return GetRootAsFB_PetMount(_bb, new FB_PetMount()); }
  public static FB_PetMount GetRootAsFB_PetMount(ByteBuffer _bb, FB_PetMount obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_PetMount __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Name { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Icon { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public int ModelID { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string NameSprite { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FakeObjID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string UnlockStep { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UnLockType { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockParam { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnLockParamSec { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool FlyMount { get { int o = __offset(24); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int GetBattleSkillList(int j) { int o = __offset(26); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int BattleSkillListLength { get { int o = __offset(26); return o != 0 ? __vector_len(o) : 0; } }
  public int DescStrId { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int UnlockDescStrId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AvatarExp { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int AvatarDesc { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsActiveShow { get { int o = __offset(36); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int RankFakeObjID { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ExpireDays { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OpenServerDay { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsShowOnUI { get { int o = __offset(44); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_PetMount> CreateFB_PetMount(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Name = default(StringOffset),
      StringOffset Icon = default(StringOffset),
      int ModelID = -1,
      StringOffset NameSprite = default(StringOffset),
      int FakeObjID = -1,
      StringOffset UnlockStep = default(StringOffset),
      int UnLockType = -1,
      int UnLockParam = -1,
      int UnLockParamSec = -1,
      bool FlyMount = false,
      VectorOffset BattleSkillList = default(VectorOffset),
      int DescStrId = 0,
      int UnlockDescStrId = 0,
      int AvatarExp = 0,
      int AvatarDesc = 0,
      bool IsActiveShow = false,
      int RankFakeObjID = 0,
      int ExpireDays = -1,
      int OpenServerDay = 0,
      bool IsShowOnUI = false) {
    builder.StartObject(21);
    FB_PetMount.AddOpenServerDay(builder, OpenServerDay);
    FB_PetMount.AddExpireDays(builder, ExpireDays);
    FB_PetMount.AddRankFakeObjID(builder, RankFakeObjID);
    FB_PetMount.AddAvatarDesc(builder, AvatarDesc);
    FB_PetMount.AddAvatarExp(builder, AvatarExp);
    FB_PetMount.AddUnlockDescStrId(builder, UnlockDescStrId);
    FB_PetMount.AddDescStrId(builder, DescStrId);
    FB_PetMount.AddBattleSkillList(builder, BattleSkillList);
    FB_PetMount.AddUnLockParamSec(builder, UnLockParamSec);
    FB_PetMount.AddUnLockParam(builder, UnLockParam);
    FB_PetMount.AddUnLockType(builder, UnLockType);
    FB_PetMount.AddUnlockStep(builder, UnlockStep);
    FB_PetMount.AddFakeObjID(builder, FakeObjID);
    FB_PetMount.AddNameSprite(builder, NameSprite);
    FB_PetMount.AddModelID(builder, ModelID);
    FB_PetMount.AddIcon(builder, Icon);
    FB_PetMount.AddName(builder, Name);
    FB_PetMount.AddId(builder, Id);
    FB_PetMount.AddIsShowOnUI(builder, IsShowOnUI);
    FB_PetMount.AddIsActiveShow(builder, IsActiveShow);
    FB_PetMount.AddFlyMount(builder, FlyMount);
    return FB_PetMount.EndFB_PetMount(builder);
  }

  public static void StartFB_PetMount(FlatBufferBuilder builder) { builder.StartObject(21); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset NameOffset) { builder.AddOffset(1, NameOffset.Value, 0); }
  public static void AddIcon(FlatBufferBuilder builder, StringOffset IconOffset) { builder.AddOffset(2, IconOffset.Value, 0); }
  public static void AddModelID(FlatBufferBuilder builder, int ModelID) { builder.AddInt(3, ModelID, -1); }
  public static void AddNameSprite(FlatBufferBuilder builder, StringOffset NameSpriteOffset) { builder.AddOffset(4, NameSpriteOffset.Value, 0); }
  public static void AddFakeObjID(FlatBufferBuilder builder, int FakeObjID) { builder.AddInt(5, FakeObjID, -1); }
  public static void AddUnlockStep(FlatBufferBuilder builder, StringOffset UnlockStepOffset) { builder.AddOffset(6, UnlockStepOffset.Value, 0); }
  public static void AddUnLockType(FlatBufferBuilder builder, int UnLockType) { builder.AddInt(7, UnLockType, -1); }
  public static void AddUnLockParam(FlatBufferBuilder builder, int UnLockParam) { builder.AddInt(8, UnLockParam, -1); }
  public static void AddUnLockParamSec(FlatBufferBuilder builder, int UnLockParamSec) { builder.AddInt(9, UnLockParamSec, -1); }
  public static void AddFlyMount(FlatBufferBuilder builder, bool FlyMount) { builder.AddBool(10, FlyMount, false); }
  public static void AddBattleSkillList(FlatBufferBuilder builder, VectorOffset BattleSkillListOffset) { builder.AddOffset(11, BattleSkillListOffset.Value, 0); }
  public static VectorOffset CreateBattleSkillListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartBattleSkillListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDescStrId(FlatBufferBuilder builder, int DescStrId) { builder.AddInt(12, DescStrId, 0); }
  public static void AddUnlockDescStrId(FlatBufferBuilder builder, int UnlockDescStrId) { builder.AddInt(13, UnlockDescStrId, 0); }
  public static void AddAvatarExp(FlatBufferBuilder builder, int AvatarExp) { builder.AddInt(14, AvatarExp, 0); }
  public static void AddAvatarDesc(FlatBufferBuilder builder, int AvatarDesc) { builder.AddInt(15, AvatarDesc, 0); }
  public static void AddIsActiveShow(FlatBufferBuilder builder, bool IsActiveShow) { builder.AddBool(16, IsActiveShow, false); }
  public static void AddRankFakeObjID(FlatBufferBuilder builder, int RankFakeObjID) { builder.AddInt(17, RankFakeObjID, 0); }
  public static void AddExpireDays(FlatBufferBuilder builder, int ExpireDays) { builder.AddInt(18, ExpireDays, -1); }
  public static void AddOpenServerDay(FlatBufferBuilder builder, int OpenServerDay) { builder.AddInt(19, OpenServerDay, 0); }
  public static void AddIsShowOnUI(FlatBufferBuilder builder, bool IsShowOnUI) { builder.AddBool(20, IsShowOnUI, false); }
  public static Offset<FB_PetMount> EndFB_PetMount(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PetMount>(o);
  }
};

public sealed class FB_PetMountContainer : Table {
  public static FB_PetMountContainer GetRootAsFB_PetMountContainer(ByteBuffer _bb) { return GetRootAsFB_PetMountContainer(_bb, new FB_PetMountContainer()); }
  public static FB_PetMountContainer GetRootAsFB_PetMountContainer(ByteBuffer _bb, FB_PetMountContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_PetMountContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_PetMountContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_PetMount GetItems(int j) { return GetItems(new FB_PetMount(), j); }
  public FB_PetMount GetItems(FB_PetMount obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_PetMountContainer> CreateFB_PetMountContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_PetMountContainer.AddItems(builder, items);
    return FB_PetMountContainer.EndFB_PetMountContainer(builder);
  }

  public static void StartFB_PetMountContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_PetMount>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_PetMountContainer> EndFB_PetMountContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_PetMountContainer>(o);
  }
  public static void FinishFB_PetMountContainerBuffer(FlatBufferBuilder builder, Offset<FB_PetMountContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
