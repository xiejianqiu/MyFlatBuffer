// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_FunctionBase : Table {
  public static FB_FunctionBase GetRootAsFB_FunctionBase(ByteBuffer _bb) { return GetRootAsFB_FunctionBase(_bb, new FB_FunctionBase()); }
  public static FB_FunctionBase GetRootAsFB_FunctionBase(ByteBuffer _bb, FB_FunctionBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_FunctionBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string FunctionName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int UnlockType { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockParam { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetSubFunctionList(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int SubFunctionListLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public int LockedType { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LockedTipsID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShowTips { get { int o = __offset(18); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsShowUI { get { int o = __offset(20); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int UIModelID { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int StrId { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string SpriteName { get { int o = __offset(26); return o != 0 ? __string(o + bb_pos) : null; } }
  public string FuncIcon { get { int o = __offset(28); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FuncDescId { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string UIName { get { int o = __offset(32); return o != 0 ? __string(o + bb_pos) : null; } }
  public string MovePath { get { int o = __offset(34); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsSunFunc { get { int o = __offset(36); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public float DelayTime { get { int o = __offset(38); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public bool IsWorldEnabled { get { int o = __offset(40); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int MailId { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsShowNewIcon { get { int o = __offset(44); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int MFId { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsActivity { get { int o = __offset(48); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_FunctionBase> CreateFB_FunctionBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset FunctionName = default(StringOffset),
      int UnlockType = -1,
      int UnlockParam = -1,
      VectorOffset SubFunctionList = default(VectorOffset),
      int LockedType = -1,
      int LockedTipsID = -1,
      bool IsShowTips = false,
      bool IsShowUI = false,
      int UIModelID = -1,
      int StrId = -1,
      StringOffset SpriteName = default(StringOffset),
      StringOffset FuncIcon = default(StringOffset),
      int FuncDescId = -1,
      StringOffset UIName = default(StringOffset),
      StringOffset MovePath = default(StringOffset),
      bool IsSunFunc = false,
      float DelayTime = -1,
      bool IsWorldEnabled = false,
      int MailId = -1,
      bool IsShowNewIcon = false,
      int MFId = -1,
      bool IsActivity = false) {
    builder.StartObject(23);
    FB_FunctionBase.AddMFId(builder, MFId);
    FB_FunctionBase.AddMailId(builder, MailId);
    FB_FunctionBase.AddDelayTime(builder, DelayTime);
    FB_FunctionBase.AddMovePath(builder, MovePath);
    FB_FunctionBase.AddUIName(builder, UIName);
    FB_FunctionBase.AddFuncDescId(builder, FuncDescId);
    FB_FunctionBase.AddFuncIcon(builder, FuncIcon);
    FB_FunctionBase.AddSpriteName(builder, SpriteName);
    FB_FunctionBase.AddStrId(builder, StrId);
    FB_FunctionBase.AddUIModelID(builder, UIModelID);
    FB_FunctionBase.AddLockedTipsID(builder, LockedTipsID);
    FB_FunctionBase.AddLockedType(builder, LockedType);
    FB_FunctionBase.AddSubFunctionList(builder, SubFunctionList);
    FB_FunctionBase.AddUnlockParam(builder, UnlockParam);
    FB_FunctionBase.AddUnlockType(builder, UnlockType);
    FB_FunctionBase.AddFunctionName(builder, FunctionName);
    FB_FunctionBase.AddID(builder, ID);
    FB_FunctionBase.AddIsActivity(builder, IsActivity);
    FB_FunctionBase.AddIsShowNewIcon(builder, IsShowNewIcon);
    FB_FunctionBase.AddIsWorldEnabled(builder, IsWorldEnabled);
    FB_FunctionBase.AddIsSunFunc(builder, IsSunFunc);
    FB_FunctionBase.AddIsShowUI(builder, IsShowUI);
    FB_FunctionBase.AddIsShowTips(builder, IsShowTips);
    return FB_FunctionBase.EndFB_FunctionBase(builder);
  }

  public static void StartFB_FunctionBase(FlatBufferBuilder builder) { builder.StartObject(23); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddFunctionName(FlatBufferBuilder builder, StringOffset FunctionNameOffset) { builder.AddOffset(1, FunctionNameOffset.Value, 0); }
  public static void AddUnlockType(FlatBufferBuilder builder, int UnlockType) { builder.AddInt(2, UnlockType, -1); }
  public static void AddUnlockParam(FlatBufferBuilder builder, int UnlockParam) { builder.AddInt(3, UnlockParam, -1); }
  public static void AddSubFunctionList(FlatBufferBuilder builder, VectorOffset SubFunctionListOffset) { builder.AddOffset(4, SubFunctionListOffset.Value, 0); }
  public static VectorOffset CreateSubFunctionListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartSubFunctionListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLockedType(FlatBufferBuilder builder, int LockedType) { builder.AddInt(5, LockedType, -1); }
  public static void AddLockedTipsID(FlatBufferBuilder builder, int LockedTipsID) { builder.AddInt(6, LockedTipsID, -1); }
  public static void AddIsShowTips(FlatBufferBuilder builder, bool IsShowTips) { builder.AddBool(7, IsShowTips, false); }
  public static void AddIsShowUI(FlatBufferBuilder builder, bool IsShowUI) { builder.AddBool(8, IsShowUI, false); }
  public static void AddUIModelID(FlatBufferBuilder builder, int UIModelID) { builder.AddInt(9, UIModelID, -1); }
  public static void AddStrId(FlatBufferBuilder builder, int StrId) { builder.AddInt(10, StrId, -1); }
  public static void AddSpriteName(FlatBufferBuilder builder, StringOffset SpriteNameOffset) { builder.AddOffset(11, SpriteNameOffset.Value, 0); }
  public static void AddFuncIcon(FlatBufferBuilder builder, StringOffset FuncIconOffset) { builder.AddOffset(12, FuncIconOffset.Value, 0); }
  public static void AddFuncDescId(FlatBufferBuilder builder, int FuncDescId) { builder.AddInt(13, FuncDescId, -1); }
  public static void AddUIName(FlatBufferBuilder builder, StringOffset UINameOffset) { builder.AddOffset(14, UINameOffset.Value, 0); }
  public static void AddMovePath(FlatBufferBuilder builder, StringOffset MovePathOffset) { builder.AddOffset(15, MovePathOffset.Value, 0); }
  public static void AddIsSunFunc(FlatBufferBuilder builder, bool IsSunFunc) { builder.AddBool(16, IsSunFunc, false); }
  public static void AddDelayTime(FlatBufferBuilder builder, float DelayTime) { builder.AddFloat(17, DelayTime, -1); }
  public static void AddIsWorldEnabled(FlatBufferBuilder builder, bool IsWorldEnabled) { builder.AddBool(18, IsWorldEnabled, false); }
  public static void AddMailId(FlatBufferBuilder builder, int MailId) { builder.AddInt(19, MailId, -1); }
  public static void AddIsShowNewIcon(FlatBufferBuilder builder, bool IsShowNewIcon) { builder.AddBool(20, IsShowNewIcon, false); }
  public static void AddMFId(FlatBufferBuilder builder, int MFId) { builder.AddInt(21, MFId, -1); }
  public static void AddIsActivity(FlatBufferBuilder builder, bool IsActivity) { builder.AddBool(22, IsActivity, false); }
  public static Offset<FB_FunctionBase> EndFB_FunctionBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FunctionBase>(o);
  }
};

public sealed class FB_FunctionBaseContainer : Table {
  public static FB_FunctionBaseContainer GetRootAsFB_FunctionBaseContainer(ByteBuffer _bb) { return GetRootAsFB_FunctionBaseContainer(_bb, new FB_FunctionBaseContainer()); }
  public static FB_FunctionBaseContainer GetRootAsFB_FunctionBaseContainer(ByteBuffer _bb, FB_FunctionBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_FunctionBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_FunctionBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_FunctionBase GetItems(int j) { return GetItems(new FB_FunctionBase(), j); }
  public FB_FunctionBase GetItems(FB_FunctionBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_FunctionBaseContainer> CreateFB_FunctionBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_FunctionBaseContainer.AddItems(builder, items);
    return FB_FunctionBaseContainer.EndFB_FunctionBaseContainer(builder);
  }

  public static void StartFB_FunctionBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_FunctionBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_FunctionBaseContainer> EndFB_FunctionBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FunctionBaseContainer>(o);
  }
  public static void FinishFB_FunctionBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_FunctionBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
