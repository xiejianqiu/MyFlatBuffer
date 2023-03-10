// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionRound : Table {
  public static FB_MissionRound GetRootAsFB_MissionRound(ByteBuffer _bb) { return GetRootAsFB_MissionRound(_bb, new FB_MissionRound()); }
  public static FB_MissionRound GetRootAsFB_MissionRound(ByteBuffer _bb, FB_MissionRound obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionRound __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LevelMin { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int LevelMax { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AdvancedMin { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int AdvancedMax { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetMissionList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MissionListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int GetWeightList(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int WeightListLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionRound> CreateFB_MissionRound(FlatBufferBuilder builder,
      int Id = 0,
      int LevelMin = -1,
      int LevelMax = -1,
      int AdvancedMin = -1,
      int AdvancedMax = -1,
      VectorOffset MissionList = default(VectorOffset),
      VectorOffset WeightList = default(VectorOffset)) {
    builder.StartObject(7);
    FB_MissionRound.AddWeightList(builder, WeightList);
    FB_MissionRound.AddMissionList(builder, MissionList);
    FB_MissionRound.AddAdvancedMax(builder, AdvancedMax);
    FB_MissionRound.AddAdvancedMin(builder, AdvancedMin);
    FB_MissionRound.AddLevelMax(builder, LevelMax);
    FB_MissionRound.AddLevelMin(builder, LevelMin);
    FB_MissionRound.AddId(builder, Id);
    return FB_MissionRound.EndFB_MissionRound(builder);
  }

  public static void StartFB_MissionRound(FlatBufferBuilder builder) { builder.StartObject(7); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddLevelMin(FlatBufferBuilder builder, int LevelMin) { builder.AddInt(1, LevelMin, -1); }
  public static void AddLevelMax(FlatBufferBuilder builder, int LevelMax) { builder.AddInt(2, LevelMax, -1); }
  public static void AddAdvancedMin(FlatBufferBuilder builder, int AdvancedMin) { builder.AddInt(3, AdvancedMin, -1); }
  public static void AddAdvancedMax(FlatBufferBuilder builder, int AdvancedMax) { builder.AddInt(4, AdvancedMax, -1); }
  public static void AddMissionList(FlatBufferBuilder builder, VectorOffset MissionListOffset) { builder.AddOffset(5, MissionListOffset.Value, 0); }
  public static VectorOffset CreateMissionListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMissionListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddWeightList(FlatBufferBuilder builder, VectorOffset WeightListOffset) { builder.AddOffset(6, WeightListOffset.Value, 0); }
  public static VectorOffset CreateWeightListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartWeightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionRound> EndFB_MissionRound(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionRound>(o);
  }
};

public sealed class FB_MissionRoundContainer : Table {
  public static FB_MissionRoundContainer GetRootAsFB_MissionRoundContainer(ByteBuffer _bb) { return GetRootAsFB_MissionRoundContainer(_bb, new FB_MissionRoundContainer()); }
  public static FB_MissionRoundContainer GetRootAsFB_MissionRoundContainer(ByteBuffer _bb, FB_MissionRoundContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionRoundContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionRoundContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionRound GetItems(int j) { return GetItems(new FB_MissionRound(), j); }
  public FB_MissionRound GetItems(FB_MissionRound obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionRoundContainer> CreateFB_MissionRoundContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionRoundContainer.AddItems(builder, items);
    return FB_MissionRoundContainer.EndFB_MissionRoundContainer(builder);
  }

  public static void StartFB_MissionRoundContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionRound>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionRoundContainer> EndFB_MissionRoundContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionRoundContainer>(o);
  }
  public static void FinishFB_MissionRoundContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionRoundContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
