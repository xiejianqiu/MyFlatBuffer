// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_LadderMission : Table {
  public static FB_LadderMission GetRootAsFB_LadderMission(ByteBuffer _bb) { return GetRootAsFB_LadderMission(_bb, new FB_LadderMission()); }
  public static FB_LadderMission GetRootAsFB_LadderMission(ByteBuffer _bb, FB_LadderMission obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_LadderMission __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int ID { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int IdStrDic { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetTargetList(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int TargetListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public int GetHonorList(int j) { int o = __offset(10); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int HonorListLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int ShowId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }

  public static Offset<FB_LadderMission> CreateFB_LadderMission(FlatBufferBuilder builder,
      int ID = 0,
      int IdStrDic = -1,
      VectorOffset TargetList = default(VectorOffset),
      VectorOffset HonorList = default(VectorOffset),
      int ShowId = -1) {
    builder.StartObject(5);
    FB_LadderMission.AddShowId(builder, ShowId);
    FB_LadderMission.AddHonorList(builder, HonorList);
    FB_LadderMission.AddTargetList(builder, TargetList);
    FB_LadderMission.AddIdStrDic(builder, IdStrDic);
    FB_LadderMission.AddID(builder, ID);
    return FB_LadderMission.EndFB_LadderMission(builder);
  }

  public static void StartFB_LadderMission(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddID(FlatBufferBuilder builder, int ID) { builder.AddInt(0, ID, 0); }
  public static void AddIdStrDic(FlatBufferBuilder builder, int IdStrDic) { builder.AddInt(1, IdStrDic, -1); }
  public static void AddTargetList(FlatBufferBuilder builder, VectorOffset TargetListOffset) { builder.AddOffset(2, TargetListOffset.Value, 0); }
  public static VectorOffset CreateTargetListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartTargetListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHonorList(FlatBufferBuilder builder, VectorOffset HonorListOffset) { builder.AddOffset(3, HonorListOffset.Value, 0); }
  public static VectorOffset CreateHonorListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartHonorListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShowId(FlatBufferBuilder builder, int ShowId) { builder.AddInt(4, ShowId, -1); }
  public static Offset<FB_LadderMission> EndFB_LadderMission(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LadderMission>(o);
  }
};

public sealed class FB_LadderMissionContainer : Table {
  public static FB_LadderMissionContainer GetRootAsFB_LadderMissionContainer(ByteBuffer _bb) { return GetRootAsFB_LadderMissionContainer(_bb, new FB_LadderMissionContainer()); }
  public static FB_LadderMissionContainer GetRootAsFB_LadderMissionContainer(ByteBuffer _bb, FB_LadderMissionContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_LadderMissionContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_LadderMissionContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_LadderMission GetItems(int j) { return GetItems(new FB_LadderMission(), j); }
  public FB_LadderMission GetItems(FB_LadderMission obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_LadderMissionContainer> CreateFB_LadderMissionContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_LadderMissionContainer.AddItems(builder, items);
    return FB_LadderMissionContainer.EndFB_LadderMissionContainer(builder);
  }

  public static void StartFB_LadderMissionContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_LadderMission>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_LadderMissionContainer> EndFB_LadderMissionContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_LadderMissionContainer>(o);
  }
  public static void FinishFB_LadderMissionContainerBuffer(FlatBufferBuilder builder, Offset<FB_LadderMissionContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
