// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_NpcDialog : Table {
  public static FB_NpcDialog GetRootAsFB_NpcDialog(ByteBuffer _bb) { return GetRootAsFB_NpcDialog(_bb, new FB_NpcDialog()); }
  public static FB_NpcDialog GetRootAsFB_NpcDialog(ByteBuffer _bb, FB_NpcDialog obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_NpcDialog __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Dialog { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public int OptionDialogId { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int OptionDialogType { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int ScriptId { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int GetMissionIDList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MissionIDListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_NpcDialog> CreateFB_NpcDialog(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Dialog = default(StringOffset),
      int OptionDialogId = -1,
      int OptionDialogType = -1,
      int ScriptId = -1,
      VectorOffset MissionIDList = default(VectorOffset)) {
    builder.StartObject(6);
    FB_NpcDialog.AddMissionIDList(builder, MissionIDList);
    FB_NpcDialog.AddScriptId(builder, ScriptId);
    FB_NpcDialog.AddOptionDialogType(builder, OptionDialogType);
    FB_NpcDialog.AddOptionDialogId(builder, OptionDialogId);
    FB_NpcDialog.AddDialog(builder, Dialog);
    FB_NpcDialog.AddId(builder, Id);
    return FB_NpcDialog.EndFB_NpcDialog(builder);
  }

  public static void StartFB_NpcDialog(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddDialog(FlatBufferBuilder builder, StringOffset DialogOffset) { builder.AddOffset(1, DialogOffset.Value, 0); }
  public static void AddOptionDialogId(FlatBufferBuilder builder, int OptionDialogId) { builder.AddInt(2, OptionDialogId, -1); }
  public static void AddOptionDialogType(FlatBufferBuilder builder, int OptionDialogType) { builder.AddInt(3, OptionDialogType, -1); }
  public static void AddScriptId(FlatBufferBuilder builder, int ScriptId) { builder.AddInt(4, ScriptId, -1); }
  public static void AddMissionIDList(FlatBufferBuilder builder, VectorOffset MissionIDListOffset) { builder.AddOffset(5, MissionIDListOffset.Value, 0); }
  public static VectorOffset CreateMissionIDListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMissionIDListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_NpcDialog> EndFB_NpcDialog(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_NpcDialog>(o);
  }
};

public sealed class FB_NpcDialogContainer : Table {
  public static FB_NpcDialogContainer GetRootAsFB_NpcDialogContainer(ByteBuffer _bb) { return GetRootAsFB_NpcDialogContainer(_bb, new FB_NpcDialogContainer()); }
  public static FB_NpcDialogContainer GetRootAsFB_NpcDialogContainer(ByteBuffer _bb, FB_NpcDialogContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_NpcDialogContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_NpcDialogContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_NpcDialog GetItems(int j) { return GetItems(new FB_NpcDialog(), j); }
  public FB_NpcDialog GetItems(FB_NpcDialog obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_NpcDialogContainer> CreateFB_NpcDialogContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_NpcDialogContainer.AddItems(builder, items);
    return FB_NpcDialogContainer.EndFB_NpcDialogContainer(builder);
  }

  public static void StartFB_NpcDialogContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_NpcDialog>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_NpcDialogContainer> EndFB_NpcDialogContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_NpcDialogContainer>(o);
  }
  public static void FinishFB_NpcDialogContainerBuffer(FlatBufferBuilder builder, Offset<FB_NpcDialogContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
