// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_GuideBase : Table {
  public static FB_GuideBase GetRootAsFB_GuideBase(ByteBuffer _bb) { return GetRootAsFB_GuideBase(_bb, new FB_GuideBase()); }
  public static FB_GuideBase GetRootAsFB_GuideBase(ByteBuffer _bb, FB_GuideBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_GuideBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int NextID { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string UIName { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public float BgAlpha { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public int IsShowArrow { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ArrowPosX { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ArrowPosY { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ArrowRotate { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool ArrowMirror { get { int o = __offset(20); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool IsShowDialog { get { int o = __offset(22); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool DialogMirror { get { int o = __offset(24); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int DialogPosX { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DialogPosY { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjectID { get { int o = __offset(30); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool FakeMirror { get { int o = __offset(32); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int FakePosX { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakePosY { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string MissionHelpMsg { get { int o = __offset(38); return o != 0 ? __string(o + bb_pos) : null; } }
  public int TextID { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SoundID { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool CanSkip { get { int o = __offset(44); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public int LiveTime { get { int o = __offset(46); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool FinishOnSkip { get { int o = __offset(48); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public bool IsInfoGuide { get { int o = __offset(50); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int UIType { get { int o = __offset(52); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string GetParamList(int j) { int o = __offset(54); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int ParamListLength { get { int o = __offset(54); return o != 0 ? __vector_len(o) : 0; } }
  public int MaskOffX { get { int o = __offset(56); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaskOffY { get { int o = __offset(58); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaskOffWidth { get { int o = __offset(60); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MaskOffHeight { get { int o = __offset(62); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool FinishGuide { get { int o = __offset(64); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool NeedRetry { get { int o = __offset(66); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool ShowMask { get { int o = __offset(68); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public bool MaskPlayTween { get { int o = __offset(70); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }
  public int MaskMaxScale { get { int o = __offset(72); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public float MaskChangeTime { get { int o = __offset(74); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }

  public static Offset<FB_GuideBase> CreateFB_GuideBase(FlatBufferBuilder builder,
      int Id = 0,
      int NextID = -1,
      StringOffset UIName = default(StringOffset),
      float BgAlpha = 0,
      int IsShowArrow = -1,
      int ArrowPosX = -1,
      int ArrowPosY = -1,
      int ArrowRotate = -1,
      bool ArrowMirror = false,
      bool IsShowDialog = false,
      bool DialogMirror = false,
      int DialogPosX = -1,
      int DialogPosY = -1,
      int FakeObjectID = -1,
      bool FakeMirror = false,
      int FakePosX = -1,
      int FakePosY = -1,
      StringOffset MissionHelpMsg = default(StringOffset),
      int TextID = -1,
      int SoundID = -1,
      bool CanSkip = true,
      int LiveTime = -1,
      bool FinishOnSkip = true,
      bool IsInfoGuide = false,
      int UIType = -1,
      VectorOffset ParamList = default(VectorOffset),
      int MaskOffX = -1,
      int MaskOffY = -1,
      int MaskOffWidth = -1,
      int MaskOffHeight = -1,
      bool FinishGuide = false,
      bool NeedRetry = false,
      bool ShowMask = false,
      bool MaskPlayTween = false,
      int MaskMaxScale = -1,
      float MaskChangeTime = -1) {
    builder.StartObject(36);
    FB_GuideBase.AddMaskChangeTime(builder, MaskChangeTime);
    FB_GuideBase.AddMaskMaxScale(builder, MaskMaxScale);
    FB_GuideBase.AddMaskOffHeight(builder, MaskOffHeight);
    FB_GuideBase.AddMaskOffWidth(builder, MaskOffWidth);
    FB_GuideBase.AddMaskOffY(builder, MaskOffY);
    FB_GuideBase.AddMaskOffX(builder, MaskOffX);
    FB_GuideBase.AddParamList(builder, ParamList);
    FB_GuideBase.AddUIType(builder, UIType);
    FB_GuideBase.AddLiveTime(builder, LiveTime);
    FB_GuideBase.AddSoundID(builder, SoundID);
    FB_GuideBase.AddTextID(builder, TextID);
    FB_GuideBase.AddMissionHelpMsg(builder, MissionHelpMsg);
    FB_GuideBase.AddFakePosY(builder, FakePosY);
    FB_GuideBase.AddFakePosX(builder, FakePosX);
    FB_GuideBase.AddFakeObjectID(builder, FakeObjectID);
    FB_GuideBase.AddDialogPosY(builder, DialogPosY);
    FB_GuideBase.AddDialogPosX(builder, DialogPosX);
    FB_GuideBase.AddArrowRotate(builder, ArrowRotate);
    FB_GuideBase.AddArrowPosY(builder, ArrowPosY);
    FB_GuideBase.AddArrowPosX(builder, ArrowPosX);
    FB_GuideBase.AddIsShowArrow(builder, IsShowArrow);
    FB_GuideBase.AddBgAlpha(builder, BgAlpha);
    FB_GuideBase.AddUIName(builder, UIName);
    FB_GuideBase.AddNextID(builder, NextID);
    FB_GuideBase.AddId(builder, Id);
    FB_GuideBase.AddMaskPlayTween(builder, MaskPlayTween);
    FB_GuideBase.AddShowMask(builder, ShowMask);
    FB_GuideBase.AddNeedRetry(builder, NeedRetry);
    FB_GuideBase.AddFinishGuide(builder, FinishGuide);
    FB_GuideBase.AddIsInfoGuide(builder, IsInfoGuide);
    FB_GuideBase.AddFinishOnSkip(builder, FinishOnSkip);
    FB_GuideBase.AddCanSkip(builder, CanSkip);
    FB_GuideBase.AddFakeMirror(builder, FakeMirror);
    FB_GuideBase.AddDialogMirror(builder, DialogMirror);
    FB_GuideBase.AddIsShowDialog(builder, IsShowDialog);
    FB_GuideBase.AddArrowMirror(builder, ArrowMirror);
    return FB_GuideBase.EndFB_GuideBase(builder);
  }

  public static void StartFB_GuideBase(FlatBufferBuilder builder) { builder.StartObject(36); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddNextID(FlatBufferBuilder builder, int NextID) { builder.AddInt(1, NextID, -1); }
  public static void AddUIName(FlatBufferBuilder builder, StringOffset UINameOffset) { builder.AddOffset(2, UINameOffset.Value, 0); }
  public static void AddBgAlpha(FlatBufferBuilder builder, float BgAlpha) { builder.AddFloat(3, BgAlpha, 0); }
  public static void AddIsShowArrow(FlatBufferBuilder builder, int IsShowArrow) { builder.AddInt(4, IsShowArrow, -1); }
  public static void AddArrowPosX(FlatBufferBuilder builder, int ArrowPosX) { builder.AddInt(5, ArrowPosX, -1); }
  public static void AddArrowPosY(FlatBufferBuilder builder, int ArrowPosY) { builder.AddInt(6, ArrowPosY, -1); }
  public static void AddArrowRotate(FlatBufferBuilder builder, int ArrowRotate) { builder.AddInt(7, ArrowRotate, -1); }
  public static void AddArrowMirror(FlatBufferBuilder builder, bool ArrowMirror) { builder.AddBool(8, ArrowMirror, false); }
  public static void AddIsShowDialog(FlatBufferBuilder builder, bool IsShowDialog) { builder.AddBool(9, IsShowDialog, false); }
  public static void AddDialogMirror(FlatBufferBuilder builder, bool DialogMirror) { builder.AddBool(10, DialogMirror, false); }
  public static void AddDialogPosX(FlatBufferBuilder builder, int DialogPosX) { builder.AddInt(11, DialogPosX, -1); }
  public static void AddDialogPosY(FlatBufferBuilder builder, int DialogPosY) { builder.AddInt(12, DialogPosY, -1); }
  public static void AddFakeObjectID(FlatBufferBuilder builder, int FakeObjectID) { builder.AddInt(13, FakeObjectID, -1); }
  public static void AddFakeMirror(FlatBufferBuilder builder, bool FakeMirror) { builder.AddBool(14, FakeMirror, false); }
  public static void AddFakePosX(FlatBufferBuilder builder, int FakePosX) { builder.AddInt(15, FakePosX, -1); }
  public static void AddFakePosY(FlatBufferBuilder builder, int FakePosY) { builder.AddInt(16, FakePosY, -1); }
  public static void AddMissionHelpMsg(FlatBufferBuilder builder, StringOffset MissionHelpMsgOffset) { builder.AddOffset(17, MissionHelpMsgOffset.Value, 0); }
  public static void AddTextID(FlatBufferBuilder builder, int TextID) { builder.AddInt(18, TextID, -1); }
  public static void AddSoundID(FlatBufferBuilder builder, int SoundID) { builder.AddInt(19, SoundID, -1); }
  public static void AddCanSkip(FlatBufferBuilder builder, bool CanSkip) { builder.AddBool(20, CanSkip, true); }
  public static void AddLiveTime(FlatBufferBuilder builder, int LiveTime) { builder.AddInt(21, LiveTime, -1); }
  public static void AddFinishOnSkip(FlatBufferBuilder builder, bool FinishOnSkip) { builder.AddBool(22, FinishOnSkip, true); }
  public static void AddIsInfoGuide(FlatBufferBuilder builder, bool IsInfoGuide) { builder.AddBool(23, IsInfoGuide, false); }
  public static void AddUIType(FlatBufferBuilder builder, int UIType) { builder.AddInt(24, UIType, -1); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(25, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMaskOffX(FlatBufferBuilder builder, int MaskOffX) { builder.AddInt(26, MaskOffX, -1); }
  public static void AddMaskOffY(FlatBufferBuilder builder, int MaskOffY) { builder.AddInt(27, MaskOffY, -1); }
  public static void AddMaskOffWidth(FlatBufferBuilder builder, int MaskOffWidth) { builder.AddInt(28, MaskOffWidth, -1); }
  public static void AddMaskOffHeight(FlatBufferBuilder builder, int MaskOffHeight) { builder.AddInt(29, MaskOffHeight, -1); }
  public static void AddFinishGuide(FlatBufferBuilder builder, bool FinishGuide) { builder.AddBool(30, FinishGuide, false); }
  public static void AddNeedRetry(FlatBufferBuilder builder, bool NeedRetry) { builder.AddBool(31, NeedRetry, false); }
  public static void AddShowMask(FlatBufferBuilder builder, bool ShowMask) { builder.AddBool(32, ShowMask, false); }
  public static void AddMaskPlayTween(FlatBufferBuilder builder, bool MaskPlayTween) { builder.AddBool(33, MaskPlayTween, false); }
  public static void AddMaskMaxScale(FlatBufferBuilder builder, int MaskMaxScale) { builder.AddInt(34, MaskMaxScale, -1); }
  public static void AddMaskChangeTime(FlatBufferBuilder builder, float MaskChangeTime) { builder.AddFloat(35, MaskChangeTime, -1); }
  public static Offset<FB_GuideBase> EndFB_GuideBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuideBase>(o);
  }
};

public sealed class FB_GuideBaseContainer : Table {
  public static FB_GuideBaseContainer GetRootAsFB_GuideBaseContainer(ByteBuffer _bb) { return GetRootAsFB_GuideBaseContainer(_bb, new FB_GuideBaseContainer()); }
  public static FB_GuideBaseContainer GetRootAsFB_GuideBaseContainer(ByteBuffer _bb, FB_GuideBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_GuideBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_GuideBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_GuideBase GetItems(int j) { return GetItems(new FB_GuideBase(), j); }
  public FB_GuideBase GetItems(FB_GuideBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_GuideBaseContainer> CreateFB_GuideBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_GuideBaseContainer.AddItems(builder, items);
    return FB_GuideBaseContainer.EndFB_GuideBaseContainer(builder);
  }

  public static void StartFB_GuideBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_GuideBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_GuideBaseContainer> EndFB_GuideBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_GuideBaseContainer>(o);
  }
  public static void FinishFB_GuideBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_GuideBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
