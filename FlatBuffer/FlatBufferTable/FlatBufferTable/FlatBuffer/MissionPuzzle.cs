// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_MissionPuzzle : Table {
  public static FB_MissionPuzzle GetRootAsFB_MissionPuzzle(ByteBuffer _bb) { return GetRootAsFB_MissionPuzzle(_bb, new FB_MissionPuzzle()); }
  public static FB_MissionPuzzle GetRootAsFB_MissionPuzzle(ByteBuffer _bb, FB_MissionPuzzle obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_MissionPuzzle __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string PuzzleID { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string GetRightList(int j) { int o = __offset(8); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int RightListLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionPuzzle> CreateFB_MissionPuzzle(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset PuzzleID = default(StringOffset),
      VectorOffset RightList = default(VectorOffset)) {
    builder.StartObject(3);
    FB_MissionPuzzle.AddRightList(builder, RightList);
    FB_MissionPuzzle.AddPuzzleID(builder, PuzzleID);
    FB_MissionPuzzle.AddId(builder, Id);
    return FB_MissionPuzzle.EndFB_MissionPuzzle(builder);
  }

  public static void StartFB_MissionPuzzle(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddPuzzleID(FlatBufferBuilder builder, StringOffset PuzzleIDOffset) { builder.AddOffset(1, PuzzleIDOffset.Value, 0); }
  public static void AddRightList(FlatBufferBuilder builder, VectorOffset RightListOffset) { builder.AddOffset(2, RightListOffset.Value, 0); }
  public static VectorOffset CreateRightListVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartRightListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionPuzzle> EndFB_MissionPuzzle(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionPuzzle>(o);
  }
};

public sealed class FB_MissionPuzzleContainer : Table {
  public static FB_MissionPuzzleContainer GetRootAsFB_MissionPuzzleContainer(ByteBuffer _bb) { return GetRootAsFB_MissionPuzzleContainer(_bb, new FB_MissionPuzzleContainer()); }
  public static FB_MissionPuzzleContainer GetRootAsFB_MissionPuzzleContainer(ByteBuffer _bb, FB_MissionPuzzleContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_MissionPuzzleContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_MissionPuzzleContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_MissionPuzzle GetItems(int j) { return GetItems(new FB_MissionPuzzle(), j); }
  public FB_MissionPuzzle GetItems(FB_MissionPuzzle obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_MissionPuzzleContainer> CreateFB_MissionPuzzleContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_MissionPuzzleContainer.AddItems(builder, items);
    return FB_MissionPuzzleContainer.EndFB_MissionPuzzleContainer(builder);
  }

  public static void StartFB_MissionPuzzleContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_MissionPuzzle>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_MissionPuzzleContainer> EndFB_MissionPuzzleContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_MissionPuzzleContainer>(o);
  }
  public static void FinishFB_MissionPuzzleContainerBuffer(FlatBufferBuilder builder, Offset<FB_MissionPuzzleContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
