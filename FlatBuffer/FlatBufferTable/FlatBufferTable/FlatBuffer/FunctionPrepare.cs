// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_FunctionPrepare : Table {
  public static FB_FunctionPrepare GetRootAsFB_FunctionPrepare(ByteBuffer _bb) { return GetRootAsFB_FunctionPrepare(_bb, new FB_FunctionPrepare()); }
  public static FB_FunctionPrepare GetRootAsFB_FunctionPrepare(ByteBuffer _bb, FB_FunctionPrepare obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_FunctionPrepare __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int FuncClass { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int MissionID { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int UnlockType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string FuncIcon { get { int o = __offset(12); return o != 0 ? __string(o + bb_pos) : null; } }
  public string FuncName { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public string FunctionName { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public string FuncSpeaker { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public int GetFakeObjIDList(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FakeObjIDListLength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public int GetFuncIntroduceList(int j) { int o = __offset(22); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FuncIntroduceListLength { get { int o = __offset(22); return o != 0 ? __vector_len(o) : 0; } }
  public int PassIndex { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int SortID { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string GetDescTwoFuncList(int j) { int o = __offset(28); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int DescTwoFuncListLength { get { int o = __offset(28); return o != 0 ? __vector_len(o) : 0; } }
  public string GetDescThreeFuncList(int j) { int o = __offset(30); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int DescThreeFuncListLength { get { int o = __offset(30); return o != 0 ? __vector_len(o) : 0; } }
  public string ChapterName { get { int o = __offset(32); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_FunctionPrepare> CreateFB_FunctionPrepare(FlatBufferBuilder builder,
      int ID = 0,
      int FuncClass = -1,
      int MissionID = -1,
      int UnlockType = -1,
      StringOffset FuncIcon = default(StringOffset),
      StringOffset FuncName = default(StringOffset),
      StringOffset FunctionName = default(StringOffset),
      StringOffset FuncSpeaker = default(StringOffset),
      VectorOffset FakeObjIDList = default(VectorOffset),
      VectorOffset FuncIntroduceList = default(VectorOffset),
      int PassIndex = -1,
      int SortID = -1,
      VectorOffset DescTwoFuncList = default(VectorOffset),
      VectorOffset DescThreeFuncList = default(VectorOffset),
      StringOffset ChapterName = default(StringOffset)) {
    builder.StartObject(15);
    FB_FunctionPrepare.AddChapterName(builder, ChapterName);
    FB_FunctionPrepare.AddDescThreeFuncList(builder, DescThreeFuncList);
    FB_FunctionPrepare.AddDescTwoFuncList(builder, DescTwoFuncList);
    FB_FunctionPrepare.AddSortID(builder, SortID);
    FB_FunctionPrepare.AddPassIndex(builder, PassIndex);
    FB_FunctionPrepare.AddFuncIntroduceList(builder, FuncIntroduceList);
    FB_FunctionPrepare.AddFakeObjIDList(builder, FakeObjIDList);
    FB_FunctionPrepare.AddFuncSpeaker(builder, FuncSpeaker);
    FB_FunctionPrepare.AddFunctionName(builder, FunctionName);
    FB_FunctionPrepare.AddFuncName(builder, FuncName);
    FB_FunctionPrepare.AddFuncIcon(builder, FuncIcon);
    FB_FunctionPrepare.AddUnlockType(builder, UnlockType);
    FB_FunctionPrepare.AddMissionID(builder, MissionID);
    FB_FunctionPrepare.AddFuncClass(builder, FuncClass);
    FB_FunctionPrepare.AddID(builder, ID);
    return FB_FunctionPrepare.EndFB_FunctionPrepare(builder);
  }

  public static void StartFB_FunctionPrepare(FlatBufferBuilder builder) { builder.StartObject(15); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddFuncClass(FlatBufferBuilder builder, int FuncClass) { builder.AddInt(1, FuncClass, -1); }
  public static void AddMissionID(FlatBufferBuilder builder, int MissionID) { builder.AddInt(2, MissionID, -1); }
  public static void AddUnlockType(FlatBufferBuilder builder, int UnlockType) { builder.AddInt(3, UnlockType, -1); }
  public static void AddFuncIcon(FlatBufferBuilder builder, StringOffset FuncIconOffset) { builder.AddOffset(4, FuncIconOffset.Value, 0); }
  public static void AddFuncName(FlatBufferBuilder builder, StringOffset FuncNameOffset) { builder.AddOffset(5, FuncNameOffset.Value, 0); }
  public static void AddFunctionName(FlatBufferBuilder builder, StringOffset FunctionNameOffset) { builder.AddOffset(6, FunctionNameOffset.Value, 0); }
  public static void AddFuncSpeaker(FlatBufferBuilder builder, StringOffset FuncSpeakerOffset) { builder.AddOffset(7, FuncSpeakerOffset.Value, 0); }
  public static void AddFakeObjIDList(FlatBufferBuilder builder, VectorOffset FakeObjIDListOffset) { builder.AddOffset(8, FakeObjIDListOffset.Value, 0); }
  public static VectorOffset CreateFakeObjIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFakeObjIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddFuncIntroduceList(FlatBufferBuilder builder, VectorOffset FuncIntroduceListOffset) { builder.AddOffset(9, FuncIntroduceListOffset.Value, 0); }
  public static VectorOffset CreateFuncIntroduceListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFuncIntroduceListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPassIndex(FlatBufferBuilder builder, int PassIndex) { builder.AddInt(10, PassIndex, -1); }
  public static void AddSortID(FlatBufferBuilder builder, int SortID) { builder.AddInt(11, SortID, -1); }
  public static void AddDescTwoFuncList(FlatBufferBuilder builder, VectorOffset DescTwoFuncListOffset) { builder.AddOffset(12, DescTwoFuncListOffset.Value, 0); }
  public static VectorOffset CreateDescTwoFuncListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartDescTwoFuncListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDescThreeFuncList(FlatBufferBuilder builder, VectorOffset DescThreeFuncListOffset) { builder.AddOffset(13, DescThreeFuncListOffset.Value, 0); }
  public static VectorOffset CreateDescThreeFuncListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartDescThreeFuncListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddChapterName(FlatBufferBuilder builder, StringOffset ChapterNameOffset) { builder.AddOffset(14, ChapterNameOffset.Value, 0); }
  public static Offset<FB_FunctionPrepare> EndFB_FunctionPrepare(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FunctionPrepare>(o);
  }
};

public sealed class FB_FunctionPrepareContainer : Table {
  public static FB_FunctionPrepareContainer GetRootAsFB_FunctionPrepareContainer(ByteBuffer _bb) { return GetRootAsFB_FunctionPrepareContainer(_bb, new FB_FunctionPrepareContainer()); }
  public static FB_FunctionPrepareContainer GetRootAsFB_FunctionPrepareContainer(ByteBuffer _bb, FB_FunctionPrepareContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_FunctionPrepareContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_FunctionPrepareContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_FunctionPrepare GetItems(int j) { return GetItems(new FB_FunctionPrepare(), j); }
  public FB_FunctionPrepare GetItems(FB_FunctionPrepare obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_FunctionPrepareContainer> CreateFB_FunctionPrepareContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_FunctionPrepareContainer.AddItems(builder, items);
    return FB_FunctionPrepareContainer.EndFB_FunctionPrepareContainer(builder);
  }

  public static void StartFB_FunctionPrepareContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_FunctionPrepare>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_FunctionPrepareContainer> EndFB_FunctionPrepareContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_FunctionPrepareContainer>(o);
  }
  public static void FinishFB_FunctionPrepareContainerBuffer(FlatBufferBuilder builder, Offset<FB_FunctionPrepareContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
