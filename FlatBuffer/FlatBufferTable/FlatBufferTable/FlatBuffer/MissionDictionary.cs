// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionDictionary : Table {
  public static FB_MissionDictionary GetRootAsFB_MissionDictionary(ByteBuffer _bb) { return GetRootAsFB_MissionDictionary(_bb, new FB_MissionDictionary()); }
  public static FB_MissionDictionary GetRootAsFB_MissionDictionary(ByteBuffer _bb, FB_MissionDictionary obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionDictionary __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string MissionName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string MissionAcceptDesc { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string MissionDoneDesc { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string MissionDoneText { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string MissionDesc { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public string FollowText { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsAutoFindPath { get { int o = __offset(18); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public bool IsCanFindPath { get { int o = __offset(20); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public int SceneEffectIdApt { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EftTypeApt { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SceneEffectIdCpt { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int EftTypeCpt { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool IsCAutoFindPath { get { int o = __offset(30); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public int GuideText { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public bool DialogGuide { get { int o = __offset(34); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public bool DialogArrow { get { int o = __offset(36); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public int BottomDict { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int BottomDelay { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string BtnAText { get { int o = __offset(42); return o != 0 ? __string(o + bb_pos) : null; } }
  public string BtnBText { get { int o = __offset(44); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_MissionDictionary> CreateFB_MissionDictionary(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset MissionName = default(StringOffset),
      StringOffset MissionAcceptDesc = default(StringOffset),
      StringOffset MissionDoneDesc = default(StringOffset),
      StringOffset MissionDoneText = default(StringOffset),
      StringOffset MissionDesc = default(StringOffset),
      StringOffset FollowText = default(StringOffset),
      bool IsAutoFindPath = true,
      bool IsCanFindPath = true,
      int SceneEffectIdApt = -1,
      int EftTypeApt = -1,
      int SceneEffectIdCpt = -1,
      int EftTypeCpt = -1,
      bool IsCAutoFindPath = true,
      int GuideText = -1,
      bool DialogGuide = true,
      bool DialogArrow = true,
      int BottomDict = -1,
      int BottomDelay = 0,
      StringOffset BtnAText = default(StringOffset),
      StringOffset BtnBText = default(StringOffset)) {
    builder.StartObject(21);
    FB_MissionDictionary.AddBtnBText(builder, BtnBText);
    FB_MissionDictionary.AddBtnAText(builder, BtnAText);
    FB_MissionDictionary.AddBottomDelay(builder, BottomDelay);
    FB_MissionDictionary.AddBottomDict(builder, BottomDict);
    FB_MissionDictionary.AddGuideText(builder, GuideText);
    FB_MissionDictionary.AddEftTypeCpt(builder, EftTypeCpt);
    FB_MissionDictionary.AddSceneEffectIdCpt(builder, SceneEffectIdCpt);
    FB_MissionDictionary.AddEftTypeApt(builder, EftTypeApt);
    FB_MissionDictionary.AddSceneEffectIdApt(builder, SceneEffectIdApt);
    FB_MissionDictionary.AddFollowText(builder, FollowText);
    FB_MissionDictionary.AddMissionDesc(builder, MissionDesc);
    FB_MissionDictionary.AddMissionDoneText(builder, MissionDoneText);
    FB_MissionDictionary.AddMissionDoneDesc(builder, MissionDoneDesc);
    FB_MissionDictionary.AddMissionAcceptDesc(builder, MissionAcceptDesc);
    FB_MissionDictionary.AddMissionName(builder, MissionName);
    FB_MissionDictionary.AddId(builder, Id);
    FB_MissionDictionary.AddDialogArrow(builder, DialogArrow);
    FB_MissionDictionary.AddDialogGuide(builder, DialogGuide);
    FB_MissionDictionary.AddIsCAutoFindPath(builder, IsCAutoFindPath);
    FB_MissionDictionary.AddIsCanFindPath(builder, IsCanFindPath);
    FB_MissionDictionary.AddIsAutoFindPath(builder, IsAutoFindPath);
    return FB_MissionDictionary.EndFB_MissionDictionary(builder);
  }

  public static void StartFB_MissionDictionary(FlatBufferBuilder builder) { builder.StartObject(21); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMissionName(FlatBufferBuilder builder, StringOffset MissionNameOffset) { builder.AddOffset(1, MissionNameOffset.Value, 0); }
  public static void AddMissionAcceptDesc(FlatBufferBuilder builder, StringOffset MissionAcceptDescOffset) { builder.AddOffset(2, MissionAcceptDescOffset.Value, 0); }
  public static void AddMissionDoneDesc(FlatBufferBuilder builder, StringOffset MissionDoneDescOffset) { builder.AddOffset(3, MissionDoneDescOffset.Value, 0); }
  public static void AddMissionDoneText(FlatBufferBuilder builder, StringOffset MissionDoneTextOffset) { builder.AddOffset(4, MissionDoneTextOffset.Value, 0); }
  public static void AddMissionDesc(FlatBufferBuilder builder, StringOffset MissionDescOffset) { builder.AddOffset(5, MissionDescOffset.Value, 0); }
  public static void AddFollowText(FlatBufferBuilder builder, StringOffset FollowTextOffset) { builder.AddOffset(6, FollowTextOffset.Value, 0); }
  public static void AddIsAutoFindPath(FlatBufferBuilder builder, bool IsAutoFindPath) { builder.AddBool(7, IsAutoFindPath, true); }
  public static void AddIsCanFindPath(FlatBufferBuilder builder, bool IsCanFindPath) { builder.AddBool(8, IsCanFindPath, true); }
  public static void AddSceneEffectIdApt(FlatBufferBuilder builder, int SceneEffectIdApt) { builder.AddInt(9, SceneEffectIdApt, -1); }
  public static void AddEftTypeApt(FlatBufferBuilder builder, int EftTypeApt) { builder.AddInt(10, EftTypeApt, -1); }
  public static void AddSceneEffectIdCpt(FlatBufferBuilder builder, int SceneEffectIdCpt) { builder.AddInt(11, SceneEffectIdCpt, -1); }
  public static void AddEftTypeCpt(FlatBufferBuilder builder, int EftTypeCpt) { builder.AddInt(12, EftTypeCpt, -1); }
  public static void AddIsCAutoFindPath(FlatBufferBuilder builder, bool IsCAutoFindPath) { builder.AddBool(13, IsCAutoFindPath, true); }
  public static void AddGuideText(FlatBufferBuilder builder, int GuideText) { builder.AddInt(14, GuideText, -1); }
  public static void AddDialogGuide(FlatBufferBuilder builder, bool DialogGuide) { builder.AddBool(15, DialogGuide, true); }
  public static void AddDialogArrow(FlatBufferBuilder builder, bool DialogArrow) { builder.AddBool(16, DialogArrow, true); }
  public static void AddBottomDict(FlatBufferBuilder builder, int BottomDict) { builder.AddInt(17, BottomDict, -1); }
  public static void AddBottomDelay(FlatBufferBuilder builder, int BottomDelay) { builder.AddInt(18, BottomDelay, 0); }
  public static void AddBtnAText(FlatBufferBuilder builder, StringOffset BtnATextOffset) { builder.AddOffset(19, BtnATextOffset.Value, 0); }
  public static void AddBtnBText(FlatBufferBuilder builder, StringOffset BtnBTextOffset) { builder.AddOffset(20, BtnBTextOffset.Value, 0); }
  public static Offset<FB_MissionDictionary> EndFB_MissionDictionary(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionDictionary>(o);
  }
};

public sealed class FB_MissionDictionaryContainer : Table {
  public static FB_MissionDictionaryContainer GetRootAsFB_MissionDictionaryContainer(ByteBuffer _bb) { return GetRootAsFB_MissionDictionaryContainer(_bb, new FB_MissionDictionaryContainer()); }
  public static FB_MissionDictionaryContainer GetRootAsFB_MissionDictionaryContainer(ByteBuffer _bb, FB_MissionDictionaryContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionDictionaryContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionDictionaryContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionDictionary GetItems(int j) { return GetItems(new FB_MissionDictionary(), j); }
  public FB_MissionDictionary GetItems(FB_MissionDictionary obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionDictionaryContainer> CreateFB_MissionDictionaryContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionDictionaryContainer.AddItems(builder, items);
    return FB_MissionDictionaryContainer.EndFB_MissionDictionaryContainer(builder);
  }

  public static void StartFB_MissionDictionaryContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionDictionary>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionDictionaryContainer> EndFB_MissionDictionaryContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionDictionaryContainer>(o);
  }
  public static void FinishFB_MissionDictionaryContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionDictionaryContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
