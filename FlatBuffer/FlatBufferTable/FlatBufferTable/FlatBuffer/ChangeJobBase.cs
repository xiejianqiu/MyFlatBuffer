// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ChangeJobBase : Table {
  public static FB_ChangeJobBase GetRootAsFB_ChangeJobBase(ByteBuffer _bb) { return GetRootAsFB_ChangeJobBase(_bb, new FB_ChangeJobBase()); }
  public static FB_ChangeJobBase GetRootAsFB_ChangeJobBase(ByteBuffer _bb, FB_ChangeJobBase obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ChangeJobBase __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string MenPaiName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string HeadPic { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string HeadPicFemale { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public string TargetHeadPic { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string TargetHeadPicFemale { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ShowIcon { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public string ShowIconFemale { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public int Type { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetParamList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ParamListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int OpenMissionID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int DictID { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FinalPhase { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetPhaseList(int j) { int o = __offset(30); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int PhaseListLength { get { int o = __offset(30); return o != 0 ? __vector_len(o) : 0; } }
  public int SkipMoney { get { int o = __offset(32); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjId { get { int o = __offset(34); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjIdFemale { get { int o = __offset(36); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CardFakeObjId { get { int o = __offset(38); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int CardFakeObjIdFemale { get { int o = __offset(40); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjIdFinish { get { int o = __offset(42); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int FakeObjIdFemaleFinish { get { int o = __offset(44); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_ChangeJobBase> CreateFB_ChangeJobBase(FlatBufferBuilder builder,
      int ID = 0,
      StringOffset MenPaiName = default(StringOffset),
      StringOffset HeadPic = default(StringOffset),
      StringOffset HeadPicFemale = default(StringOffset),
      StringOffset TargetHeadPic = default(StringOffset),
      StringOffset TargetHeadPicFemale = default(StringOffset),
      StringOffset ShowIcon = default(StringOffset),
      StringOffset ShowIconFemale = default(StringOffset),
      int Type = -1,
      VectorOffset ParamList = default(VectorOffset),
      int OpenMissionID = -1,
      int DictID = -1,
      int FinalPhase = -1,
      VectorOffset PhaseList = default(VectorOffset),
      int SkipMoney = -1,
      int FakeObjId = -1,
      int FakeObjIdFemale = -1,
      int CardFakeObjId = -1,
      int CardFakeObjIdFemale = -1,
      int FakeObjIdFinish = -1,
      int FakeObjIdFemaleFinish = -1) {
    builder.StartObject(21);
    FB_ChangeJobBase.AddFakeObjIdFemaleFinish(builder, FakeObjIdFemaleFinish);
    FB_ChangeJobBase.AddFakeObjIdFinish(builder, FakeObjIdFinish);
    FB_ChangeJobBase.AddCardFakeObjIdFemale(builder, CardFakeObjIdFemale);
    FB_ChangeJobBase.AddCardFakeObjId(builder, CardFakeObjId);
    FB_ChangeJobBase.AddFakeObjIdFemale(builder, FakeObjIdFemale);
    FB_ChangeJobBase.AddFakeObjId(builder, FakeObjId);
    FB_ChangeJobBase.AddSkipMoney(builder, SkipMoney);
    FB_ChangeJobBase.AddPhaseList(builder, PhaseList);
    FB_ChangeJobBase.AddFinalPhase(builder, FinalPhase);
    FB_ChangeJobBase.AddDictID(builder, DictID);
    FB_ChangeJobBase.AddOpenMissionID(builder, OpenMissionID);
    FB_ChangeJobBase.AddParamList(builder, ParamList);
    FB_ChangeJobBase.AddType(builder, Type);
    FB_ChangeJobBase.AddShowIconFemale(builder, ShowIconFemale);
    FB_ChangeJobBase.AddShowIcon(builder, ShowIcon);
    FB_ChangeJobBase.AddTargetHeadPicFemale(builder, TargetHeadPicFemale);
    FB_ChangeJobBase.AddTargetHeadPic(builder, TargetHeadPic);
    FB_ChangeJobBase.AddHeadPicFemale(builder, HeadPicFemale);
    FB_ChangeJobBase.AddHeadPic(builder, HeadPic);
    FB_ChangeJobBase.AddMenPaiName(builder, MenPaiName);
    FB_ChangeJobBase.AddID(builder, ID);
    return FB_ChangeJobBase.EndFB_ChangeJobBase(builder);
  }

  public static void StartFB_ChangeJobBase(FlatBufferBuilder builder) { builder.StartObject(21); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddMenPaiName(FlatBufferBuilder builder, StringOffset MenPaiNameOffset) { builder.AddOffset(1, MenPaiNameOffset.Value, 0); }
  public static void AddHeadPic(FlatBufferBuilder builder, StringOffset HeadPicOffset) { builder.AddOffset(2, HeadPicOffset.Value, 0); }
  public static void AddHeadPicFemale(FlatBufferBuilder builder, StringOffset HeadPicFemaleOffset) { builder.AddOffset(3, HeadPicFemaleOffset.Value, 0); }
  public static void AddTargetHeadPic(FlatBufferBuilder builder, StringOffset TargetHeadPicOffset) { builder.AddOffset(4, TargetHeadPicOffset.Value, 0); }
  public static void AddTargetHeadPicFemale(FlatBufferBuilder builder, StringOffset TargetHeadPicFemaleOffset) { builder.AddOffset(5, TargetHeadPicFemaleOffset.Value, 0); }
  public static void AddShowIcon(FlatBufferBuilder builder, StringOffset ShowIconOffset) { builder.AddOffset(6, ShowIconOffset.Value, 0); }
  public static void AddShowIconFemale(FlatBufferBuilder builder, StringOffset ShowIconFemaleOffset) { builder.AddOffset(7, ShowIconFemaleOffset.Value, 0); }
  public static void AddType(FlatBufferBuilder builder, int Type) { builder.AddInt(8, Type, -1); }
  public static void AddParamList(FlatBufferBuilder builder, VectorOffset ParamListOffset) { builder.AddOffset(9, ParamListOffset.Value, 0); }
  public static VectorOffset CreateParamListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartParamListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOpenMissionID(FlatBufferBuilder builder, int OpenMissionID) { builder.AddInt(10, OpenMissionID, -1); }
  public static void AddDictID(FlatBufferBuilder builder, int DictID) { builder.AddInt(11, DictID, -1); }
  public static void AddFinalPhase(FlatBufferBuilder builder, int FinalPhase) { builder.AddInt(12, FinalPhase, -1); }
  public static void AddPhaseList(FlatBufferBuilder builder, VectorOffset PhaseListOffset) { builder.AddOffset(13, PhaseListOffset.Value, 0); }
  public static VectorOffset CreatePhaseListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartPhaseListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkipMoney(FlatBufferBuilder builder, int SkipMoney) { builder.AddInt(14, SkipMoney, -1); }
  public static void AddFakeObjId(FlatBufferBuilder builder, int FakeObjId) { builder.AddInt(15, FakeObjId, -1); }
  public static void AddFakeObjIdFemale(FlatBufferBuilder builder, int FakeObjIdFemale) { builder.AddInt(16, FakeObjIdFemale, -1); }
  public static void AddCardFakeObjId(FlatBufferBuilder builder, int CardFakeObjId) { builder.AddInt(17, CardFakeObjId, -1); }
  public static void AddCardFakeObjIdFemale(FlatBufferBuilder builder, int CardFakeObjIdFemale) { builder.AddInt(18, CardFakeObjIdFemale, -1); }
  public static void AddFakeObjIdFinish(FlatBufferBuilder builder, int FakeObjIdFinish) { builder.AddInt(19, FakeObjIdFinish, -1); }
  public static void AddFakeObjIdFemaleFinish(FlatBufferBuilder builder, int FakeObjIdFemaleFinish) { builder.AddInt(20, FakeObjIdFemaleFinish, -1); }
  public static Offset<FB_ChangeJobBase> EndFB_ChangeJobBase(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChangeJobBase>(o);
  }
};

public sealed class FB_ChangeJobBaseContainer : Table {
  public static FB_ChangeJobBaseContainer GetRootAsFB_ChangeJobBaseContainer(ByteBuffer _bb) { return GetRootAsFB_ChangeJobBaseContainer(_bb, new FB_ChangeJobBaseContainer()); }
  public static FB_ChangeJobBaseContainer GetRootAsFB_ChangeJobBaseContainer(ByteBuffer _bb, FB_ChangeJobBaseContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ChangeJobBaseContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ChangeJobBaseContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ChangeJobBase GetItems(int j) { return GetItems(new FB_ChangeJobBase(), j); }
  public FB_ChangeJobBase GetItems(FB_ChangeJobBase obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ChangeJobBaseContainer> CreateFB_ChangeJobBaseContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ChangeJobBaseContainer.AddItems(builder, items);
    return FB_ChangeJobBaseContainer.EndFB_ChangeJobBaseContainer(builder);
  }

  public static void StartFB_ChangeJobBaseContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ChangeJobBase>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ChangeJobBaseContainer> EndFB_ChangeJobBaseContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ChangeJobBaseContainer>(o);
  }
  public static void FinishFB_ChangeJobBaseContainerBuffer(FlatBufferBuilder builder, Offset<FB_ChangeJobBaseContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
